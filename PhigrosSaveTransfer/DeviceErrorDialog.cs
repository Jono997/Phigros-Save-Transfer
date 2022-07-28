using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhigrosSaveTransfer
{
    public partial class DeviceErrorDialog : Form
    {
        public DeviceErrorDialog()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void Exit()
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            if (Global.TestDevice())
                Exit();
            else
                MessageBox.Show("Device check failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            Exit();
        }
    }
}
