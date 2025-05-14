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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }
        private int nextButtonX = 123;
        private const int ButtonWidth = 369;
        private const int ButtonHeight = 208;
        private const int ButtonSpacing = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            NameWorkSpace Dialog = new NameWorkSpace();
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                string name = Dialog.WorkSpaceName;
                Button newBtn = new Button();  
                newBtn.Text = name;
                newBtn.Size = new Size(ButtonWidth, ButtonHeight);
                newBtn.Location = button1.Location;
                newBtn.Click += (s, ev) =>
                {
                    MessageBox.Show($"Добро пожаловать в рабочую область {name}");
                };
                this.Controls.Add(newBtn);
                newBtn.Location = new Point(
                    newBtn.Location.X + ButtonWidth + ButtonSpacing,
                    newBtn.Location.Y
                    
                    );
            }
            
        }
    }
}
