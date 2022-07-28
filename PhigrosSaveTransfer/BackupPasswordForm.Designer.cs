
namespace PhigrosSaveTransfer
{
    partial class BackupPasswordForm
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
            this.noPasswordRadioButton = new System.Windows.Forms.RadioButton();
            this.backupPasswordPromptLabel = new System.Windows.Forms.Label();
            this.passwordRadioButton = new System.Windows.Forms.RadioButton();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noPasswordRadioButton
            // 
            this.noPasswordRadioButton.AutoSize = true;
            this.noPasswordRadioButton.Checked = true;
            this.noPasswordRadioButton.Location = new System.Drawing.Point(12, 25);
            this.noPasswordRadioButton.Name = "noPasswordRadioButton";
            this.noPasswordRadioButton.Size = new System.Drawing.Size(87, 17);
            this.noPasswordRadioButton.TabIndex = 0;
            this.noPasswordRadioButton.TabStop = true;
            this.noPasswordRadioButton.Text = "No password";
            this.noPasswordRadioButton.UseVisualStyleBackColor = true;
            // 
            // backupPasswordPromptLabel
            // 
            this.backupPasswordPromptLabel.AutoSize = true;
            this.backupPasswordPromptLabel.Location = new System.Drawing.Point(12, 9);
            this.backupPasswordPromptLabel.Name = "backupPasswordPromptLabel";
            this.backupPasswordPromptLabel.Size = new System.Drawing.Size(180, 13);
            this.backupPasswordPromptLabel.TabIndex = 1;
            this.backupPasswordPromptLabel.Text = "Does this backup have a password?";
            // 
            // passwordRadioButton
            // 
            this.passwordRadioButton.AutoSize = true;
            this.passwordRadioButton.Location = new System.Drawing.Point(12, 48);
            this.passwordRadioButton.Name = "passwordRadioButton";
            this.passwordRadioButton.Size = new System.Drawing.Size(71, 17);
            this.passwordRadioButton.TabIndex = 2;
            this.passwordRadioButton.Text = "Password";
            this.passwordRadioButton.UseVisualStyleBackColor = true;
            this.passwordRadioButton.CheckedChanged += new System.EventHandler(this.passwordRadioButton_CheckedChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 74);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Location = new System.Drawing.Point(71, 71);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(236, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.Location = new System.Drawing.Point(12, 97);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(295, 44);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // BackupPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 153);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordRadioButton);
            this.Controls.Add(this.backupPasswordPromptLabel);
            this.Controls.Add(this.noPasswordRadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupPasswordForm";
            this.Text = "Backup password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackupPasswordForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton noPasswordRadioButton;
        private System.Windows.Forms.Label backupPasswordPromptLabel;
        private System.Windows.Forms.RadioButton passwordRadioButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button confirmButton;
    }
}