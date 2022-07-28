using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PhigrosSaveTransfer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Global.Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!Global.FunctionalSystems.AllExceptDevice)
                MessageBox.Show("One or more key component of Phigros Save Transfer could not be found. Please go into settings and resolve this issue.", "Missing component", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!Global.FunctionalSystems.Device)
            {
                DeviceErrorDialog errorDialog = new DeviceErrorDialog();
                bool looping = true;
                while (looping)
                {
                    DialogResult result = errorDialog.ShowDialog();
                    switch (result)
                    {
                        case DialogResult.OK:
                            looping = false;
                            break;
                        case DialogResult.Cancel:
                            Global.KillADB();
                            return;
                    }
                }
            }
            Application.Run(new MainForm());
            Global.KillADB();
        }
    }
}
