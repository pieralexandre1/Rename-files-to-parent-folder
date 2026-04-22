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
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm(string message)
        {
            InitializeComponent();
            imageInformation.Image = System.Drawing.SystemIcons.Information.ToBitmap();
            labelText.Text = message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
