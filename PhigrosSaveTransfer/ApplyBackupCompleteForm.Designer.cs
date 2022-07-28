
namespace PhigrosSaveTransfer
{
    partial class ApplyBackupCompleteForm
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
            this.appliedLabel = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appliedLabel
            // 
            this.appliedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appliedLabel.Location = new System.Drawing.Point(12, 9);
            this.appliedLabel.Name = "appliedLabel";
            this.appliedLabel.Size = new System.Drawing.Size(399, 49);
            this.appliedLabel.TabIndex = 0;
            this.appliedLabel.Text = "The backup has been applied!\r\nIf the apply failed for whatever reason, click retr" +
    "y to bring the apply prompt back up on your device.";
            // 
            // retryButton
            // 
            this.retryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.retryButton.Location = new System.Drawing.Point(12, 61);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(399, 51);
            this.retryButton.TabIndex = 1;
            this.retryButton.Text = "Retry";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // ApplyBackupCompleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 124);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.appliedLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplyBackupCompleteForm";
            this.Text = "Backup apply complete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplyBackupCompleteForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label appliedLabel;
        private System.Windows.Forms.Button retryButton;
    }
}