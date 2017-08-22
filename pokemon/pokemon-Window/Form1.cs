using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_Window
{
    public partial class pokemongo : Form
    {
        public pokemongo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pokeName.Text = "";
            pokeHeight.Text = "";
            pokeWeight.Text = "";
            pokeCategory.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message.Text = string.Format("已登錄圖鑑:{0}!", pokeName.Text);
            listBox1.Items.Add(pokeName.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
