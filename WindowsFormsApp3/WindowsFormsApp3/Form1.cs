using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class NameWorkSpace : Form
    {
        public string WorkSpaceName 
        { 
            get; 
            private set;
        }
        public NameWorkSpace()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameSpace.Text)) 
            {
                 WorkSpaceName = NameSpace.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите название области");
            }
        }

        private void NameSpace_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
