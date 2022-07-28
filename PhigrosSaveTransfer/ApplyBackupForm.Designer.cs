
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
            this.TapTapRadioButton = new System.Windows.Forms.RadioButton();
            this.GooglePlayRadioButton = new System.Windows.Forms.RadioButton();
            this.applyButton = new System.Windows.Forms.Button();
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
            // TapTapRadioButton
            // 
            this.TapTapRadioButton.AutoSize = true;
            this.TapTapRadioButton.Checked = true;
            this.TapTapRadioButton.Location = new System.Drawing.Point(12, 25);
            this.TapTapRadioButton.Name = "TapTapRadioButton";
            this.TapTapRadioButton.Size = new System.Drawing.Size(63, 17);
            this.TapTapRadioButton.TabIndex = 1;
            this.TapTapRadioButton.TabStop = true;
            this.TapTapRadioButton.Text = "TapTap";
            this.TapTapRadioButton.UseVisualStyleBackColor = true;
            // 
            // GooglePlayRadioButton
            // 
            this.GooglePlayRadioButton.AutoSize = true;
            this.GooglePlayRadioButton.Location = new System.Drawing.Point(12, 48);
            this.GooglePlayRadioButton.Name = "GooglePlayRadioButton";
            this.GooglePlayRadioButton.Size = new System.Drawing.Size(82, 17);
            this.GooglePlayRadioButton.TabIndex = 2;
            this.GooglePlayRadioButton.TabStop = true;
            this.GooglePlayRadioButton.Text = "Google Play";
            this.GooglePlayRadioButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(12, 71);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(269, 39);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply backup";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // ApplyBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 122);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.GooglePlayRadioButton);
            this.Controls.Add(this.TapTapRadioButton);
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
        private System.Windows.Forms.RadioButton TapTapRadioButton;
        private System.Windows.Forms.RadioButton GooglePlayRadioButton;
        private System.Windows.Forms.Button applyButton;
    }
}