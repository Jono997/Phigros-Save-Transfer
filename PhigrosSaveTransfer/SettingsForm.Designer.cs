
namespace PhigrosSaveTransfer
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.javaPathLabel = new System.Windows.Forms.Label();
            this.javaPathTextBox = new System.Windows.Forms.TextBox();
            this.javaPathButton = new System.Windows.Forms.Button();
            this.ADBPathButton = new System.Windows.Forms.Button();
            this.ADBPathTextBox = new System.Windows.Forms.TextBox();
            this.ADBPathLabel = new System.Windows.Forms.Label();
            this.ABEPathButton = new System.Windows.Forms.Button();
            this.ABEPathTextBox = new System.Windows.Forms.TextBox();
            this.ABEPathLabel = new System.Windows.Forms.Label();
            this.tarPathButton = new System.Windows.Forms.Button();
            this.tarPathTextBox = new System.Windows.Forms.TextBox();
            this.tarPathLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backupSizeLabel = new System.Windows.Forms.Label();
            this.bytesLabel = new System.Windows.Forms.Label();
            this.backupSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupSizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // javaPathLabel
            // 
            this.javaPathLabel.AutoSize = true;
            this.javaPathLabel.Location = new System.Drawing.Point(12, 9);
            this.javaPathLabel.Name = "javaPathLabel";
            this.javaPathLabel.Size = new System.Drawing.Size(54, 13);
            this.javaPathLabel.TabIndex = 0;
            this.javaPathLabel.Text = "Java path";
            // 
            // javaPathTextBox
            // 
            this.javaPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.javaPathTextBox.Location = new System.Drawing.Point(12, 25);
            this.javaPathTextBox.Name = "javaPathTextBox";
            this.javaPathTextBox.Size = new System.Drawing.Size(743, 20);
            this.javaPathTextBox.TabIndex = 1;
            // 
            // javaPathButton
            // 
            this.javaPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.javaPathButton.Location = new System.Drawing.Point(761, 23);
            this.javaPathButton.Name = "javaPathButton";
            this.javaPathButton.Size = new System.Drawing.Size(27, 23);
            this.javaPathButton.TabIndex = 2;
            this.javaPathButton.Text = "...";
            this.javaPathButton.UseVisualStyleBackColor = true;
            this.javaPathButton.Click += new System.EventHandler(this.javaPathButton_Click);
            // 
            // ADBPathButton
            // 
            this.ADBPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ADBPathButton.Location = new System.Drawing.Point(761, 62);
            this.ADBPathButton.Name = "ADBPathButton";
            this.ADBPathButton.Size = new System.Drawing.Size(27, 23);
            this.ADBPathButton.TabIndex = 5;
            this.ADBPathButton.Text = "...";
            this.ADBPathButton.UseVisualStyleBackColor = true;
            this.ADBPathButton.Click += new System.EventHandler(this.ADBPathButton_Click);
            // 
            // ADBPathTextBox
            // 
            this.ADBPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ADBPathTextBox.Location = new System.Drawing.Point(12, 64);
            this.ADBPathTextBox.Name = "ADBPathTextBox";
            this.ADBPathTextBox.Size = new System.Drawing.Size(743, 20);
            this.ADBPathTextBox.TabIndex = 4;
            // 
            // ADBPathLabel
            // 
            this.ADBPathLabel.AutoSize = true;
            this.ADBPathLabel.Location = new System.Drawing.Point(12, 48);
            this.ADBPathLabel.Name = "ADBPathLabel";
            this.ADBPathLabel.Size = new System.Drawing.Size(53, 13);
            this.ADBPathLabel.TabIndex = 3;
            this.ADBPathLabel.Text = "ADB path";
            // 
            // ABEPathButton
            // 
            this.ABEPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ABEPathButton.Location = new System.Drawing.Point(761, 101);
            this.ABEPathButton.Name = "ABEPathButton";
            this.ABEPathButton.Size = new System.Drawing.Size(27, 23);
            this.ABEPathButton.TabIndex = 8;
            this.ABEPathButton.Text = "...";
            this.ABEPathButton.UseVisualStyleBackColor = true;
            this.ABEPathButton.Click += new System.EventHandler(this.ABEPathButton_Click);
            // 
            // ABEPathTextBox
            // 
            this.ABEPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ABEPathTextBox.Location = new System.Drawing.Point(12, 103);
            this.ABEPathTextBox.Name = "ABEPathTextBox";
            this.ABEPathTextBox.Size = new System.Drawing.Size(743, 20);
            this.ABEPathTextBox.TabIndex = 7;
            // 
            // ABEPathLabel
            // 
            this.ABEPathLabel.AutoSize = true;
            this.ABEPathLabel.Location = new System.Drawing.Point(12, 87);
            this.ABEPathLabel.Name = "ABEPathLabel";
            this.ABEPathLabel.Size = new System.Drawing.Size(52, 13);
            this.ABEPathLabel.TabIndex = 6;
            this.ABEPathLabel.Text = "ABE path";
            // 
            // tarPathButton
            // 
            this.tarPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tarPathButton.Location = new System.Drawing.Point(761, 140);
            this.tarPathButton.Name = "tarPathButton";
            this.tarPathButton.Size = new System.Drawing.Size(27, 23);
            this.tarPathButton.TabIndex = 11;
            this.tarPathButton.Text = "...";
            this.tarPathButton.UseVisualStyleBackColor = true;
            this.tarPathButton.Click += new System.EventHandler(this.tarPathButton_Click);
            // 
            // tarPathTextBox
            // 
            this.tarPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tarPathTextBox.Location = new System.Drawing.Point(12, 142);
            this.tarPathTextBox.Name = "tarPathTextBox";
            this.tarPathTextBox.Size = new System.Drawing.Size(743, 20);
            this.tarPathTextBox.TabIndex = 10;
            // 
            // tarPathLabel
            // 
            this.tarPathLabel.AutoSize = true;
            this.tarPathLabel.Location = new System.Drawing.Point(12, 126);
            this.tarPathLabel.Name = "tarPathLabel";
            this.tarPathLabel.Size = new System.Drawing.Size(43, 13);
            this.tarPathLabel.TabIndex = 9;
            this.tarPathLabel.Text = "tar path";
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Location = new System.Drawing.Point(235, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(538, 38);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 285);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 44);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // checkButton
            // 
            this.checkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkButton.Location = new System.Drawing.Point(3, 3);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(226, 38);
            this.checkButton.TabIndex = 13;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // backupSizeLabel
            // 
            this.backupSizeLabel.AutoSize = true;
            this.backupSizeLabel.Location = new System.Drawing.Point(12, 170);
            this.backupSizeLabel.Name = "backupSizeLabel";
            this.backupSizeLabel.Size = new System.Drawing.Size(111, 13);
            this.backupSizeLabel.TabIndex = 14;
            this.backupSizeLabel.Text = "Backup size threshold";
            // 
            // bytesLabel
            // 
            this.bytesLabel.AutoSize = true;
            this.bytesLabel.Location = new System.Drawing.Point(255, 170);
            this.bytesLabel.Name = "bytesLabel";
            this.bytesLabel.Size = new System.Drawing.Size(14, 13);
            this.bytesLabel.TabIndex = 15;
            this.bytesLabel.Text = "B";
            // 
            // backupSizeNumericUpDown
            // 
            this.backupSizeNumericUpDown.Increment = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.backupSizeNumericUpDown.Location = new System.Drawing.Point(129, 168);
            this.backupSizeNumericUpDown.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.backupSizeNumericUpDown.Name = "backupSizeNumericUpDown";
            this.backupSizeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.backupSizeNumericUpDown.TabIndex = 16;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.backupSizeNumericUpDown);
            this.Controls.Add(this.bytesLabel);
            this.Controls.Add(this.backupSizeLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tarPathButton);
            this.Controls.Add(this.tarPathTextBox);
            this.Controls.Add(this.tarPathLabel);
            this.Controls.Add(this.ABEPathButton);
            this.Controls.Add(this.ABEPathTextBox);
            this.Controls.Add(this.ABEPathLabel);
            this.Controls.Add(this.ADBPathButton);
            this.Controls.Add(this.ADBPathTextBox);
            this.Controls.Add(this.ADBPathLabel);
            this.Controls.Add(this.javaPathButton);
            this.Controls.Add(this.javaPathTextBox);
            this.Controls.Add(this.javaPathLabel);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backupSizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label javaPathLabel;
        private System.Windows.Forms.TextBox javaPathTextBox;
        private System.Windows.Forms.Button javaPathButton;
        private System.Windows.Forms.Button ADBPathButton;
        private System.Windows.Forms.TextBox ADBPathTextBox;
        private System.Windows.Forms.Label ADBPathLabel;
        private System.Windows.Forms.Button ABEPathButton;
        private System.Windows.Forms.TextBox ABEPathTextBox;
        private System.Windows.Forms.Label ABEPathLabel;
        private System.Windows.Forms.Button tarPathButton;
        private System.Windows.Forms.TextBox tarPathTextBox;
        private System.Windows.Forms.Label tarPathLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label backupSizeLabel;
        private System.Windows.Forms.Label bytesLabel;
        private System.Windows.Forms.NumericUpDown backupSizeNumericUpDown;
    }
}