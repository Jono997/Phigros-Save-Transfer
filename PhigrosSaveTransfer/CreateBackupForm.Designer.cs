
namespace PhigrosSaveTransfer
{
    partial class CreateBackupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.originComboBox = new System.Windows.Forms.ComboBox();
            this.createBackupButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backupNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the version of Phigros you\'re getting this backup from";
            // 
            // originComboBox
            // 
            this.originComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originComboBox.FormattingEnabled = true;
            this.originComboBox.Location = new System.Drawing.Point(9, 68);
            this.originComboBox.Name = "originComboBox";
            this.originComboBox.Size = new System.Drawing.Size(332, 21);
            this.originComboBox.TabIndex = 1;
            this.originComboBox.SelectedIndexChanged += new System.EventHandler(this.originComboBox_SelectedIndexChanged);
            // 
            // createBackupButton
            // 
            this.createBackupButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createBackupButton.Enabled = false;
            this.createBackupButton.Location = new System.Drawing.Point(12, 96);
            this.createBackupButton.Name = "createBackupButton";
            this.createBackupButton.Size = new System.Drawing.Size(332, 47);
            this.createBackupButton.TabIndex = 2;
            this.createBackupButton.Text = "Create backup";
            this.createBackupButton.UseVisualStyleBackColor = true;
            this.createBackupButton.Click += new System.EventHandler(this.createBackupButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Backup name";
            // 
            // backupNameTextBox
            // 
            this.backupNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backupNameTextBox.Location = new System.Drawing.Point(12, 29);
            this.backupNameTextBox.Name = "backupNameTextBox";
            this.backupNameTextBox.Size = new System.Drawing.Size(332, 20);
            this.backupNameTextBox.TabIndex = 4;
            // 
            // CreateBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 155);
            this.Controls.Add(this.backupNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createBackupButton);
            this.Controls.Add(this.originComboBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateBackupForm";
            this.Text = "Create backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox originComboBox;
        private System.Windows.Forms.Button createBackupButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox backupNameTextBox;
    }
}