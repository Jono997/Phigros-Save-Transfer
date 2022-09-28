using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PhigrosSaveTransfer
{
    internal static class Global
    {
        internal static Settings settings;

        internal static class Paths
        {
            internal static string Root, Data, Working, Settings, BackupsDir, BackupData, LogDir, Log, Manifest;

            internal static string Java { get { return settings.JavaPath; } }
            internal static string ADB { get { return settings.ADBPath; } }
            internal static string ABE { get { return settings.ABEPath; } }
            internal static string Tar { get { return settings.TarPath; } }

            internal static string Backup(string backup_name)
            {
                return Path.Combine(BackupsDir, backup_name.Replace(':', ' ').Replace('/', ' ') + ".ab");
            }
        }

        internal static class FunctionalSystems
        {
            internal static bool Java, ADB, Device, Tar;

            internal static bool AllExceptDevice
            {
                get
                {
                    return Java && ADB && Tar;
                }
            }

            internal static bool All
            {
                get
                {
                    return AllExceptDevice && Device;
                }
            }
        }

        internal static Dictionary<string, BackupData.BackupOrigin> ManifestKeys;

        internal static AppVersion[] AppVersions;

        internal static List<BackupData> backups;

        /// <summary>
        /// If true, KillADB() will do nothing, unless force is true. This is used for debugging purposes as having to do reconfirm again and again and again is annoying af.
        /// </summary>
        private static bool NoADBKill;

        internal static void Init()
        {
            string[] args = Environment.GetCommandLineArgs();
            NoADBKill = (args.Length > 1 && args[1] == "noadbkill");

            #region Initialise paths
            Paths.Root       = Path.GetFullPath(Path.Combine(Environment.GetCommandLineArgs()[0], ".."));
            Paths.Data       = Path.Combine(Paths.Root, "PST_Data");
            Paths.Working    = Path.Combine(Paths.Data, "working");
            Paths.Settings   = Path.Combine(Paths.Data, "settings.xml");
            Paths.BackupsDir = Path.Combine(Paths.Data, "backups");
            Paths.BackupData = Path.Combine(Paths.Data, "backupdata.xml");
            Paths.LogDir     = Path.Combine(Paths.Data, "logs");
            Paths.Log        = Path.Combine(Paths.LogDir, $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}.log");
            Paths.Manifest   = Path.Combine(Paths.Working, "apps", File.ReadAllText(Path.Combine(Paths.Root, "appid")), "_manifest");
            #endregion

            // Working directory cleanup (in case PST crashes while there's files in there)
            CleanWorkingDirectory();

            #region Load manifest keys
            AppVersions = ReadXML<AppVersion[]>("keys.xml");

            ManifestKeys = new Dictionary<string, BackupData.BackupOrigin>();
            ManifestKeys.Add(File.ReadAllText(Path.Combine(Paths.Root, "taptap.key")), BackupData.BackupOrigin.TapTap);
            ManifestKeys.Add(File.ReadAllText(Path.Combine(Paths.Root, "googleplay.key")), BackupData.BackupOrigin.GooglePlay);
            #endregion

            #region Ensure directories exist
            Directory.CreateDirectory(Paths.BackupsDir);
            Directory.CreateDirectory(Paths.LogDir);
            #endregion

            #region Load settings
            if (File.Exists(Paths.Settings))
            {
                settings = ReadXML<Settings>(Paths.Settings);
            }
            else
                settings = new Settings();
            #endregion

            #region Load backups
            if (File.Exists(Paths.BackupData))
                backups = ReadXML<List<BackupData>>(Paths.BackupData);
            else
                backups = new List<BackupData>();
            #endregion

            #region Run tests
            TestJava();
            if (TestADB())
                TestDevice();
            else
                FunctionalSystems.Device = false;
            TestTar();
            #endregion
        }

        /// <summary>
        /// Deletes and recreates the working directory as a quick and dirty way of ensuring there is nothing inside to interfere with new operations
        /// </summary>
        internal static void CleanWorkingDirectory()
        {
            if (Directory.Exists(Paths.Working))
            {
                foreach (string dir in Directory.GetDirectories(Paths.Working))
                    Directory.Delete(dir, true);
                foreach (string file in Directory.GetFiles(Paths.Working))
                    File.Delete(file);
            }
            else
                Directory.CreateDirectory(Paths.Working);
        }

        internal static T ReadXML<T>(string path)
        {
            XmlSerializer serialiser = new XmlSerializer(typeof(T));
            StreamReader reader = new StreamReader(path);
            T retVal = (T)serialiser.Deserialize(reader);
            reader.Close();
            return retVal;
        }

        internal static void WriteXML<T>(string path, T contents)
        {
            XmlSerializer serialiser = new XmlSerializer(typeof(T));
            StreamWriter writer = new StreamWriter(path);
            serialiser.Serialize(writer, contents);
            writer.Close();
        }

        internal static string CMD(string command)
        {
            return CMD(command, Paths.Data);
        }

        internal static string CMD(string command, string directory)
        {
            Process shell_process = new Process();
            shell_process.StartInfo.CreateNoWindow = true;
            shell_process.StartInfo.UseShellExecute = false;
            shell_process.StartInfo.RedirectStandardOutput = true;
            shell_process.StartInfo.FileName = "cmd";
            shell_process.StartInfo.Arguments = $"/c \"{command}\"";
            shell_process.StartInfo.WorkingDirectory = directory;
            shell_process.Start();
            string retVal = shell_process.StandardOutput.ReadToEnd();
            shell_process.WaitForExit();
            string log = $"{DateTime.Now.ToString("G")}\n{directory}>cmd {shell_process.StartInfo.Arguments}\n{retVal}";
            Console.WriteLine(log);
            if (File.Exists(Paths.Log))
                File.AppendAllText(Paths.Log, $"\n{log}");
            else
                File.WriteAllText(Paths.Log, log);

            return retVal;
        }

        internal static string ADB(string command)
        {
            return CMD($@"""{Paths.ADB}"" {command}");
        }

        internal static string ADB(string command, string path)
        {
            return CMD($@"""{Paths.ADB}"" {command}", path);
        }

        internal static void KillADB(bool force)
        {
            if (!NoADBKill || force)
                ADB("kill-server");
        }

        internal static void KillADB()
        {
            KillADB(false);
        }

        internal static string GetManifestKey()
        {
            return File.ReadAllLines(Paths.Manifest)[7];
        }

        #region Tests
        internal static bool TestJava()
        {
            bool result = CMD($@"""{Paths.Java}"" -jar ""{Paths.Data}\javatest.jar""").Contains("Java detected");
            FunctionalSystems.Java = result;
            return result;
        }

        internal static bool TestADB()
        {
            KillADB();
            string output = ADB("");
            bool result = output.ToLower().Contains("android debug bridge");
            FunctionalSystems.ADB = result;
            return result;
        }

        #region TestDevice
        internal static bool TestDevice()
        {
            // There are two valid_device() calls here.
            // The second one, called if the first one fails, is the "actual" check, restarting the ADB service beforehand to ensure a fresh slate
            // The first one is more of a failsafe, in case the user didn't hit accept in time and the check returned false, but they still hit accept. In the event of this, the first call should succeed and we can skip the actual check.
            bool result = valid_device();
            if (!result)
            {
                KillADB();
                result = valid_device();
            }    
            FunctionalSystems.Device = result;
            return result;
        }

        private static bool valid_device()
        {
            string output = ADB("devices");
            Regex device_regex = new Regex(@".+?\t(device|unauthorized)", RegexOptions.Multiline);
            bool device_found = false;
            foreach (Match m in device_regex.Matches(output))
            {
                if (device_found)
                    return false;
                if (m.Groups[1].Value == "device")
                    device_found = true;
                else
                    return false;
            }
            return device_found;
        }
        #endregion

        internal static bool TestTar()
        {
            bool result = false;
            CMD($@"""{Paths.Tar}"" -xf ""..\tartest.tar""", Paths.Working);
            if (File.Exists(Path.Combine(Paths.Working, "test.txt")) && File.ReadAllText(Path.Combine(Paths.Working, "test.txt")).Contains("Tar detected"))
            {
                File.Delete(Path.Combine(Paths.Working, "test.txt"));
                result = true;
            }
            FunctionalSystems.Tar = result;
            return result;
        }
        #endregion
    }

    public class Settings
    {
        public string JavaPath;
        public string ABEPath;
        public string ADBPath;
        public string TarPath;
        public long GoodBackupSize;
        public Settings()
        {
            JavaPath = "java";
            ABEPath = Path.Combine(Global.Paths.Data, "abe.jar");
            ADBPath = Path.Combine(Global.Paths.Data, "adb.exe");
            TarPath = "tar";
            GoodBackupSize = 7500 * 1000;
        }
    }
}
