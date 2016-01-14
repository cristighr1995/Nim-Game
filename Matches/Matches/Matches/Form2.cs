using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Matches
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string name1, name2;
        public string Item1
        {
            get { return name1;}
        }
        public string Item2
        {
            get { return name2; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                name1 = textBox1.Text;
                name2 = textBox2.Text;
                this.Dispose();
            }
            else
            {
                if (textBox1.Text == "" && textBox2.Text != "") MessageBox.Show("Nu ati introdus numele primului jucator !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (textBox2.Text == "" && textBox1.Text != "") MessageBox.Show("Nu ati introdus numele celui de-al doilea jucator !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (textBox1.Text == "" && textBox2.Text == "") MessageBox.Show("Introduceti numele jucatorilor !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
