using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rename_files_to_parent_folder
{
    public partial class CustomMessageBox : Form
    {
        private bool messageAlternate = false;
        private string message1;
        private string message2;
        public CustomMessageBox(string message, string message1, string message2)
        {
            InitializeComponent();
            this.Icon = System.Drawing.SystemIcons.Error;
            this.Text = message;
            messageBox.Text = message1;
            this.message1 = message1;
            this.message2 = message2;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (!messageAlternate)
            {
                messageAlternate = true;
                messageBox.Text = this.message2;
                btnAlter.Text = "Simple";

            }
            else
            {
                messageAlternate = false;
                messageBox.Text = this.message1;
                btnAlter.Text = "Detailed";
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(messageBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not copy text to clipboard: " + ex.ToString());
            }
        }
    }
}
