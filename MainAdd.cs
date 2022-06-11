using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace lab3fix
{
    public partial class MainAdd : Form
    {
        public MainAdd()
        {
            InitializeComponent();
            List<string> x = new List<string>();
            comboBox1.Items.AddRange(x.ToArray());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox6.SelectedItem);
        }
    }
}
