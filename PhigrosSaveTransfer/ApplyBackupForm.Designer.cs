
namespace PhigrosSaveTransfer
{
    partial class ApplyBackupForm
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
            this.versionLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.versionsListBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(12, 9);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(119, 13);
            this.versionLabel.TabIndex = 0;
            this.versionLabel.Text = "Apply to which version?";
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(12, 54);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(269, 39);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply backup";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // versionsListBox
            // 
            this.versionsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.versionsListBox.FormattingEnabled = true;
            this.versionsListBox.Location = new System.Drawing.Point(12, 25);
            this.versionsListBox.Name = "versionsListBox";
            this.versionsListBox.Size = new System.Drawing.Size(269, 21);
            this.versionsListBox.TabIndex = 4;
            this.versionsListBox.SelectedIndexChanged += new System.EventHandler(this.versionsListBox_SelectedIndexChanged);
            // 
            // ApplyBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 105);
            this.Controls.Add(this.versionsListBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.versionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplyBackupForm";
            this.Text = "Apply Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.ComboBox versionsListBox;
    }
}