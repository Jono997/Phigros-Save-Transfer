
namespace PhigrosSaveTransfer
{
    partial class MainForm
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
            this.backupsListBox = new System.Windows.Forms.ListBox();
            this.backupsLabel = new System.Windows.Forms.Label();
            this.createBackupButton = new System.Windows.Forms.Button();
            this.applyBackupButton = new System.Windows.Forms.Button();
            this.deleteBackupButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backupsListBox
            // 
            this.backupsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.backupsListBox.FormattingEnabled = true;
            this.backupsListBox.Location = new System.Drawing.Point(12, 25);
            this.backupsListBox.Name = "backupsListBox";
            this.backupsListBox.Size = new System.Drawing.Size(547, 420);
            this.backupsListBox.TabIndex = 0;
            this.backupsListBox.SelectedIndexChanged += new System.EventHandler(this.backupsListBox_SelectedIndexChanged);
            // 
            // backupsLabel
            // 
            this.backupsLabel.AutoSize = true;
            this.backupsLabel.Location = new System.Drawing.Point(12, 9);
            this.backupsLabel.Name = "backupsLabel";
            this.backupsLabel.Size = new System.Drawing.Size(49, 13);
            this.backupsLabel.TabIndex = 1;
            this.backupsLabel.Text = "Backups";
            // 
            // createBackupButton
            // 
            this.createBackupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createBackupButton.Location = new System.Drawing.Point(565, 25);
            this.createBackupButton.Name = "createBackupButton";
            this.createBackupButton.Size = new System.Drawing.Size(108, 69);
            this.createBackupButton.TabIndex = 2;
            this.createBackupButton.Text = "Create backup";
            this.createBackupButton.UseVisualStyleBackColor = true;
            this.createBackupButton.Click += new System.EventHandler(this.createBackupButton_Click);
            // 
            // applyBackupButton
            // 
            this.applyBackupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyBackupButton.Location = new System.Drawing.Point(565, 100);
            this.applyBackupButton.Name = "applyBackupButton";
            this.applyBackupButton.Size = new System.Drawing.Size(108, 69);
            this.applyBackupButton.TabIndex = 3;
            this.applyBackupButton.Text = "Apply backup";
            this.applyBackupButton.UseVisualStyleBackColor = true;
            this.applyBackupButton.Click += new System.EventHandler(this.applyBackupButton_Click);
            // 
            // deleteBackupButton
            // 
            this.deleteBackupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBackupButton.Location = new System.Drawing.Point(565, 175);
            this.deleteBackupButton.Name = "deleteBackupButton";
            this.deleteBackupButton.Size = new System.Drawing.Size(108, 69);
            this.deleteBackupButton.TabIndex = 4;
            this.deleteBackupButton.Text = "Delete backup";
            this.deleteBackupButton.UseVisualStyleBackColor = true;
            this.deleteBackupButton.Click += new System.EventHandler(this.deleteBackupButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.Location = new System.Drawing.Point(565, 250);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(108, 69);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.deleteBackupButton);
            this.Controls.Add(this.applyBackupButton);
            this.Controls.Add(this.createBackupButton);
            this.Controls.Add(this.backupsLabel);
            this.Controls.Add(this.backupsListBox);
            this.Name = "MainForm";
            this.Text = "Phigros Save Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox backupsListBox;
        private System.Windows.Forms.Label backupsLabel;
        private System.Windows.Forms.Button createBackupButton;
        private System.Windows.Forms.Button applyBackupButton;
        private System.Windows.Forms.Button deleteBackupButton;
        private System.Windows.Forms.Button settingsButton;
    }
}

