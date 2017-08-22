using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples2
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = string.Format("Hello{0}", nameTextBox.Text);
            //MessageBox.Show("Hello" + nameTextBox.Text)
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            messageLabel.Text = string.Format("Hello{0}", nameTextBox.Text);
            nameTextBox.BackColor = SystemColors.Info;
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            nameTextBox.BackColor = SystemColors.MenuHighlight;
        }
    }
}