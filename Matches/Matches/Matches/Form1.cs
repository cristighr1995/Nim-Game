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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool[] first = new bool[2];
        bool[] rand = new bool[4];
        int[] contor = new int[16];
        int suma2 = 0, suma3 = 0, suma4 = 0;
        int nrBete = 16;
        int scor1 = 0, scor2 = 0;
        int nrBeteRand1 = 3;
        int nrBeteRand2 = 5;
        int nrBeteRand3 = 7;

        private void Restart()
        {
            pictureBox1.Visible = true; panel1.Visible = true; panel1.BackColor = Color.Transparent;
            pictureBox2.Visible = true; panel2.Visible = true; panel2.BackColor = Color.Transparent;
            pictureBox3.Visible = true; panel3.Visible = true; panel3.BackColor = Color.Transparent;
            pictureBox4.Visible = true; panel4.Visible = true; panel4.BackColor = Color.Transparent;
            pictureBox5.Visible = true; panel5.Visible = true; panel5.BackColor = Color.Transparent;
            pictureBox6.Visible = true; panel6.Visible = true; panel6.BackColor = Color.Transparent;
            pictureBox7.Visible = true; panel7.Visible = true; panel7.BackColor = Color.Transparent;
            pictureBox8.Visible = true; panel8.Visible = true; panel8.BackColor = Color.Transparent;
            pictureBox9.Visible = true; panel9.Visible = true; panel9.BackColor = Color.Transparent;
            pictureBox10.Visible = true; panel10.Visible = true; panel10.BackColor = Color.Transparent;
            pictureBox11.Visible = true; panel11.Visible = true; panel11.BackColor = Color.Transparent;
            pictureBox12.Visible = true; panel12.Visible = true; panel12.BackColor = Color.Transparent;
            pictureBox13.Visible = true; panel13.Visible = true; panel13.BackColor = Color.Transparent;
            pictureBox14.Visible = true; panel14.Visible = true; panel14.BackColor = Color.Transparent;
            pictureBox15.Visible = true; panel15.Visible = true; panel15.BackColor = Color.Transparent;
            pictureBox16.Visible = true; panel16.Visible = true; panel16.BackColor = Color.Transparent;
            pictureBox17.Enabled = true;
            pictureBox18.Enabled = true;
            pictureBox19.Enabled = true;
            for (int i = 0; i < 16; i++) contor[i] = 0;
            for (int i = 0; i < 4; i++) rand[i] = false;
            nrBete = 16; nrBeteRand1 = 3; nrBeteRand2 = 5; nrBeteRand3 = 7;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.ShowDialog();
            if (loginForm.Item1 != "" && loginForm.Item2 != "")
            {
                label1.Text = loginForm.Item1;
                label2.Text = loginForm.Item2;
            }

            first[0] = true;
            first[1] = false;
            for (int i = 0; i < 4; i++)
            { rand[i] = false; }
            for (int i = 0; i < 16; i++)
            { contor[i] = 0; }

            label4.Enabled = false;
            pictureBox17.Enabled = true;
            pictureBox18.Enabled = true;
            pictureBox19.Enabled = true;

            label3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\button2.jpg");
            label3.BackgroundImageLayout = ImageLayout.Stretch;

            label4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\button1.jpg");
            label4.BackgroundImageLayout = ImageLayout.Stretch;

            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;
            panel8.BackColor = Color.Transparent;
            panel9.BackColor = Color.Transparent;
            panel10.BackColor = Color.Transparent;
            panel11.BackColor = Color.Transparent;
            panel12.BackColor = Color.Transparent;
            panel13.BackColor = Color.Transparent;
            panel14.BackColor = Color.Transparent;
            panel15.BackColor = Color.Transparent;
            panel16.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (rand[1] == false && rand[2] == false && rand[3] == false)
            {
                if (contor[0] == 0)
                {
                    if (first[0] == true)
                    {
                        panel1.BackgroundImage = null;
                        panel1.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel1.BackgroundImage = null;
                        panel1.BackColor = Color.Red;
                    }
                    rand[0] = true;
                    contor[0] = 1;
                }
                else
                {
                    panel1.BackColor = Color.Transparent;
                    rand[0] = false;
                    contor[0] = 0;
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[2] == false && rand[3] == false)
            {
                if (contor[1] == 0)
                {
                    if (first[0] == true)
                    {
                        panel2.BackgroundImage = null;
                        panel2.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel2.BackgroundImage = null;
                        panel2.BackColor = Color.Red;
                    }
                    rand[1] = true;
                    contor[1] = 1;
                }
                else
                {
                    panel2.BackColor = Color.Transparent;
                    contor[1] = 0;
                    suma2 = contor[1] + contor[2] + contor[3];
                    if (suma2 == 0)
                        rand[1] = false;
                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[2] == false && rand[3] == false)
            {
                if (contor[2] == 0)
                {
                    if (first[0] == true)
                    {
                        panel3.BackgroundImage = null;
                        panel3.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel3.BackgroundImage = null;
                        panel3.BackColor = Color.Red;
                    }
                    rand[1] = true;
                    contor[2] = 1;
                }
                else
                {
                    panel3.BackColor = Color.Transparent;
                    contor[2] = 0;
                    suma2 = contor[1] + contor[2] + contor[3];
                    if (suma2 == 0)
                        rand[1] = false;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[2] == false && rand[3] == false)
            {
                if (contor[3] == 0)
                {
                    if (first[0] == true)
                    {
                        panel4.BackgroundImage = null;
                        panel4.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel4.BackgroundImage = null;
                        panel4.BackColor = Color.Red;
                    }
                    rand[1] = true;
                    contor[3] = 1;
                }
                else
                {
                    panel4.BackColor = Color.Transparent;
                    contor[3] = 0;
                    suma2 = contor[1] + contor[2] + contor[3];
                    if (suma2 == 0)
                        rand[1] = false;
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[3] == false)
            {
                if (contor[4] == 0)
                {
                    if (first[0] == true)
                    {
                        panel5.BackgroundImage = null;
                        panel5.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel5.BackgroundImage = null;
                        panel5.BackColor = Color.Red;
                    }
                    rand[2] = true;
                    contor[4] = 1;
                }
                else
                {
                    panel5.BackColor = Color.Transparent;
                    contor[4] = 0;
                    suma3 = contor[4] + contor[5] + contor[6] + contor[7] + contor[8];
                    if (suma3 == 0)
                        rand[2] = false;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[3] == false)
            {
                if (contor[5] == 0)
                {
                    if (first[0] == true)
                    {
                        panel6.BackgroundImage = null;
                        panel6.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel6.BackgroundImage = null;
                        panel6.BackColor = Color.Red;
                    }
                    rand[2] = true;
                    contor[5] = 1;
                }
                else
                {
                    panel6.BackColor = Color.Transparent;
                    contor[5] = 0;
                    suma3 = contor[4] + contor[5] + contor[6] + contor[7] + contor[8];
                    if (suma3 == 0)
                        rand[2] = false;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[3] == false)
            {
                if (contor[6] == 0)
                {
                    if (first[0] == true)
                    {
                        panel7.BackgroundImage = null;
                        panel7.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel7.BackgroundImage = null;
                        panel7.BackColor = Color.Red;
                    }
                    rand[2] = true;
                    contor[6] = 1;
                }
                else
                {
                    panel7.BackColor = Color.Transparent;
                    contor[6] = 0;
                    suma3 = contor[4] + contor[5] + contor[6] + contor[7] + contor[8];
                    if (suma3 == 0)
                        rand[2] = false;
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[3] == false)
            {
                if (contor[7] == 0)
                {
                    if (first[0] == true)
                    {
                        panel8.BackgroundImage = null;
                        panel8.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel8.BackgroundImage = null;
                        panel8.BackColor = Color.Red;
                    }
                    rand[2] = true;
                    contor[7] = 1;
                }
                else
                {
                    panel8.BackColor = Color.Transparent;
                    contor[7] = 0;
                    suma3 = contor[4] + contor[5] + contor[6] + contor[7] + contor[8];
                    if (suma3 == 0)
                        rand[2] = false;
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[3] == false)
            {
                if (contor[8] == 0)
                {
                    if (first[0] == true)
                    {
                        panel9.BackgroundImage = null;
                        panel9.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel9.BackgroundImage = null;
                        panel9.BackColor = Color.Red;
                    }
                    rand[2] = true;
                    contor[8] = 1;
                }
                else
                {
                    panel9.BackColor = Color.Transparent;
                    contor[8] = 0;
                    suma3 = contor[4] + contor[5] + contor[6] + contor[7] + contor[8];
                    if (suma3 == 0)
                        rand[2] = false;
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[2] == false)
            {
                if (contor[9] == 0)
                {
                    if (first[0] == true)
                    {
                        panel10.BackgroundImage = null;
                        panel10.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel10.BackgroundImage = null;
                        panel10.BackColor = Color.Red;
                    }
                    rand[3] = true;
                    contor[9] = 1;
                }
                else
                {
                    panel10.BackColor = Color.Transparent;
                    contor[9] = 0;
                    suma4 = contor[9] + contor[10] + contor[11] + contor[12] + contor[13] + contor[14] + contor[15];
                    if (suma4 == 0)
                        rand[3] = false;
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[2] == false)
            {
                if (contor[10] == 0)
                {
                    if (first[0] == true)
                    {
                        panel11.BackgroundImage = null;
                        panel11.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel11.BackgroundImage = null;
                        panel11.BackColor = Color.Red;
                    }
                    rand[3] = true;
                    contor[10] = 1;
                }
                else
                {
                    panel11.BackColor = Color.Transparent;
                    contor[10] = 0;
                    suma4 = contor[9] + contor[10] + contor[11] + contor[12] + contor[13] + contor[14] + contor[15];
                    if (suma4 == 0)
                        rand[3] = false;
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[2] == false)
            {
                if (contor[11] == 0)
                {
                    if (first[0] == true)
                    {
                        panel12.BackgroundImage = null;
                        panel12.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel12.BackgroundImage = null;
                        panel12.BackColor = Color.Red;
                    }
                    rand[3] = true;
                    contor[11] = 1;
                }
                else
                {
                    panel12.BackColor = Color.Transparent;
                    contor[11] = 0;
                    suma4 = contor[9] + contor[10] + contor[11] + contor[12] + contor[13] + contor[14] + contor[15];
                    if (suma4 == 0)
                        rand[3] = false;
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[2] == false)
            {
                if (contor[12] == 0)
                {
                    if (first[0] == true)
                    {
                        panel13.BackgroundImage = null;
                        panel13.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel13.BackgroundImage = null;
                        panel13.BackColor = Color.Red;
                    }
                    rand[3] = true;
                    contor[12] = 1;
                }
                else
                {
                    panel13.BackColor = Color.Transparent;
                    contor[12] = 0;
                    suma4 = contor[9] + contor[10] + contor[11] + contor[12] + contor[13] + contor[14] + contor[15];
                    if (suma4 == 0)
                        rand[3] = false;
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[2] == false)
            {
                if (contor[13] == 0)
                {
                    if (first[0] == true)
                    {
                        panel14.BackgroundImage = null;
                        panel14.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel14.BackgroundImage = null;
                        panel14.BackColor = Color.Red;
                    }
                    rand[3] = true;
                    contor[13] = 1;
                }
                else
                {
                    panel14.BackColor = Color.Transparent;
                    contor[13] = 0;
                    suma4 = contor[9] + contor[10] + contor[11] + contor[12] + contor[13] + contor[14] + contor[15];
                    if (suma4 == 0)
                        rand[3] = false;
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[2] == false)
            {
                if (contor[14] == 0)
                {
                    if (first[0] == true)
                    {
                        panel15.BackgroundImage = null;
                        panel15.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel15.BackgroundImage = null;
                        panel15.BackColor = Color.Red;
                    }
                    rand[3] = true;
                    contor[14] = 1;
                }
                else
                {
                    panel15.BackColor = Color.Transparent;
                    contor[14] = 0;
                    suma4 = contor[9] + contor[10] + contor[11] + contor[12] + contor[13] + contor[14] + contor[15];
                    if (suma4 == 0)
                        rand[3] = false;
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[2] == false)
            {
                if (contor[15] == 0)
                {
                    if (first[0] == true)
                    {
                        panel16.BackgroundImage = null;
                        panel16.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel16.BackgroundImage = null;
                        panel16.BackColor = Color.Red;
                    }
                    rand[3] = true;
                    contor[15] = 1;
                }
                else
                {
                    panel16.BackColor = Color.Transparent;
                    contor[15] = 0;
                    suma4 = contor[9] + contor[10] + contor[11] + contor[12] + contor[13] + contor[14] + contor[15];
                    if (suma4 == 0)
                        rand[3] = false;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[2] == false && rand[3] == false)
            {
                MessageBox.Show("You should pick a match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                label3.Enabled = false;
                label4.Enabled = true;
                if (contor[0] == 1)
                { pictureBox1.Visible = false; panel1.BackColor = Color.Transparent; nrBete--; }
                if (contor[1] == 1)
                { pictureBox2.Visible = false; panel2.BackColor = Color.Transparent; panel2.Visible = false; nrBete--; nrBeteRand1--; }
                if (contor[2] == 1)
                { pictureBox3.Visible = false; panel3.BackColor = Color.Transparent; panel3.Visible = false; nrBete--; nrBeteRand1--; }
                if (contor[3] == 1)
                { pictureBox4.Visible = false; panel4.BackColor = Color.Transparent; panel4.Visible = false; nrBete--; nrBeteRand1--; }
                if (contor[4] == 1)
                { pictureBox5.Visible = false; panel5.BackColor = Color.Transparent; panel5.Visible = false; nrBete--; nrBeteRand2--; }
                if (contor[5] == 1)
                { pictureBox6.Visible = false; panel6.BackColor = Color.Transparent; panel6.Visible = false; nrBete--; nrBeteRand2--; }
                if (contor[6] == 1)
                { pictureBox7.Visible = false; panel7.BackColor = Color.Transparent; panel7.Visible = false; nrBete--; nrBeteRand2--; }
                if (contor[7] == 1)
                { pictureBox8.Visible = false; panel8.BackColor = Color.Transparent; panel8.Visible = false; nrBete--; nrBeteRand2--; }
                if (contor[8] == 1)
                { pictureBox9.Visible = false; panel9.BackColor = Color.Transparent; panel9.Visible = false; nrBete--; nrBeteRand2--; }
                if (contor[9] == 1)
                { pictureBox10.Visible = false; panel10.BackColor = Color.Transparent; panel10.Visible = false; nrBete--; nrBeteRand3--; }
                if (contor[10] == 1)
                { pictureBox11.Visible = false; panel11.BackColor = Color.Transparent; panel11.Visible = false; nrBete--; nrBeteRand3--; }
                if (contor[11] == 1)
                { pictureBox12.Visible = false; panel12.BackColor = Color.Transparent; panel12.Visible = false; nrBete--; nrBeteRand3--; }
                if (contor[12] == 1)
                { pictureBox13.Visible = false; panel13.BackColor = Color.Transparent; panel13.Visible = false; nrBete--; nrBeteRand3--; }
                if (contor[13] == 1)
                { pictureBox14.Visible = false; panel14.BackColor = Color.Transparent; panel14.Visible = false; nrBete--; nrBeteRand3--; }
                if (contor[14] == 1)
                { pictureBox15.Visible = false; panel15.BackColor = Color.Transparent; panel15.Visible = false; nrBete--; nrBeteRand3--; }
                if (contor[15] == 1)
                { pictureBox16.Visible = false; panel16.BackColor = Color.Transparent; panel16.Visible = false; nrBete--; nrBeteRand3--; }

                if (nrBeteRand1 == 0) pictureBox17.Enabled = false;
                if (nrBeteRand2 == 0) pictureBox18.Enabled = false;
                if (nrBeteRand3 == 0) pictureBox19.Enabled = false;

                for (int i = 0; i < 4; i++)
                    rand[i] = false;
                for (int j = 0; j < 16; j++)
                    contor[j] = 0;

                first[0] = false;
                first[1] = true;

                if (nrBete == 1)
                {
                    MessageBox.Show("Winner " + label1.Text + "!    ", "Game over", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    scor1++;
                    label5.Text = scor1.ToString();
                    Restart();
                    first[0] = true;
                    first[1] = false;
                    label3.Enabled = true;
                    label4.Enabled = false;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[2] == false && rand[3] == false)
            {
                MessageBox.Show("You should pick a match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                label4.Enabled = false;
                label3.Enabled = true;
                if (contor[0] == 1)
                { pictureBox1.Visible = false; panel1.BackColor = Color.Transparent; nrBete--; }
                if (contor[1] == 1)
                { pictureBox2.Visible = false; panel2.BackColor = Color.Transparent; panel2.Visible = false; nrBete--; nrBeteRand1--; }
                if (contor[2] == 1)
                { pictureBox3.Visible = false; panel3.BackColor = Color.Transparent; panel3.Visible = false; nrBete--; nrBeteRand1--; }
                if (contor[3] == 1)
                { pictureBox4.Visible = false; panel4.BackColor = Color.Transparent; panel4.Visible = false; nrBete--; nrBeteRand1--; }
                if (contor[4] == 1)
                { pictureBox5.Visible = false; panel5.BackColor = Color.Transparent; panel5.Visible = false; nrBete--; nrBeteRand2--; }
                if (contor[5] == 1)
                { pictureBox6.Visible = false; panel6.BackColor = Color.Transparent; panel6.Visible = false; nrBete--; nrBeteRand2--; }
                if (contor[6] == 1)
                { pictureBox7.Visible = false; panel7.BackColor = Color.Transparent; panel7.Visible = false; nrBete--; nrBeteRand2--; }
                if (contor[7] == 1)
                { pictureBox8.Visible = false; panel8.BackColor = Color.Transparent; panel8.Visible = false; nrBete--; nrBeteRand2--; }
                if (contor[8] == 1)
                { pictureBox9.Visible = false; panel9.BackColor = Color.Transparent; panel9.Visible = false; nrBete--; nrBeteRand2--; }
                if (contor[9] == 1)
                { pictureBox10.Visible = false; panel10.BackColor = Color.Transparent; panel10.Visible = false; nrBete--; nrBeteRand3--; }
                if (contor[10] == 1)
                { pictureBox11.Visible = false; panel11.BackColor = Color.Transparent; panel11.Visible = false; nrBete--; nrBeteRand3--; }
                if (contor[11] == 1)
                { pictureBox12.Visible = false; panel12.BackColor = Color.Transparent; panel12.Visible = false; nrBete--; nrBeteRand3--; }
                if (contor[12] == 1)
                { pictureBox13.Visible = false; panel13.BackColor = Color.Transparent; panel13.Visible = false; nrBete--; nrBeteRand3--; }
                if (contor[13] == 1)
                { pictureBox14.Visible = false; panel14.BackColor = Color.Transparent; panel14.Visible = false; nrBete--; nrBeteRand3--; }
                if (contor[14] == 1)
                { pictureBox15.Visible = false; panel15.BackColor = Color.Transparent; panel15.Visible = false; nrBete--; nrBeteRand3--; }
                if (contor[15] == 1)
                { pictureBox16.Visible = false; panel16.BackColor = Color.Transparent; panel16.Visible = false; nrBete--; nrBeteRand3--; }

                if (nrBeteRand1 == 0) pictureBox17.Enabled = false;
                if (nrBeteRand2 == 0) pictureBox18.Enabled = false;
                if (nrBeteRand3 == 0) pictureBox19.Enabled = false;

                for (int i = 0; i < 4; i++)
                    rand[i] = false;
                for (int j = 0; j < 16; j++)
                    contor[j] = 0;

                first[0] = true;
                first[1] = false;

                if (nrBete == 1)
                {
                    MessageBox.Show("Winner " + label2.Text + "!    ", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    scor2++;
                    label6.Text = scor2.ToString();
                    Restart();
                    first[0] = false;
                    first[1] = true;
                    label4.Enabled = true;
                    label3.Enabled = false;
                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[2] == false && rand[3] == false)
            {
                if (contor[1] == 1 && contor[2] == 1 && contor[3] == 1)
                {
                    panel2.BackColor = Color.Transparent;
                    panel3.BackColor = Color.Transparent;
                    panel4.BackColor = Color.Transparent;
                    contor[1] = 0; contor[2] = 0; contor[3] = 0;
                    rand[1] = false;
                }
                else
                {
                    if (first[0] == true)
                    {
                        panel2.BackgroundImage = null;
                        panel2.BackColor = Color.LimeGreen;
                        panel3.BackgroundImage = null;
                        panel3.BackColor = Color.LimeGreen;
                        panel4.BackgroundImage = null;
                        panel4.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel2.BackgroundImage = null;
                        panel2.BackColor = Color.Red;
                        panel3.BackgroundImage = null;
                        panel3.BackColor = Color.Red;
                        panel4.BackgroundImage = null;
                        panel4.BackColor = Color.Red;
                    }
                    rand[1] = true;
                    if(panel2.Visible==true) contor[1] = 1; 
                    if(panel3.Visible==true) contor[2] = 1; 
                    if(panel4.Visible==true) contor[3] = 1;
                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[3] == false)
            {
                if (contor[4] == 1 && contor[5] == 1 && contor[6] == 1 && contor[7] == 1 && contor[8] == 1)
                {
                    panel5.BackColor = Color.Transparent;
                    panel6.BackColor = Color.Transparent;
                    panel7.BackColor = Color.Transparent;
                    panel8.BackColor = Color.Transparent;
                    panel9.BackColor = Color.Transparent;
                    contor[4] = 0; contor[5] = 0; contor[6] = 0; contor[7] = 0; contor[8] = 0;
                    rand[2] = false;
                }
                else
                {
                    if (first[0] == true)
                    {
                        panel5.BackgroundImage = null;
                        panel5.BackColor = Color.LimeGreen;
                        panel6.BackgroundImage = null;
                        panel6.BackColor = Color.LimeGreen;
                        panel7.BackgroundImage = null;
                        panel7.BackColor = Color.LimeGreen;
                        panel8.BackgroundImage = null;
                        panel8.BackColor = Color.LimeGreen;
                        panel9.BackgroundImage = null;
                        panel9.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel5.BackgroundImage = null;
                        panel5.BackColor = Color.Red;
                        panel6.BackgroundImage = null;
                        panel6.BackColor = Color.Red;
                        panel7.BackgroundImage = null;
                        panel7.BackColor = Color.Red;
                        panel8.BackgroundImage = null;
                        panel8.BackColor = Color.Red;
                        panel9.BackgroundImage = null;
                        panel9.BackColor = Color.Red;
                    }
                    rand[2] = true;
                    if (panel5.Visible == true) contor[4] = 1;
                    if (panel6.Visible == true) contor[5] = 1;
                    if (panel7.Visible == true) contor[6] = 1;
                    if (panel8.Visible == true) contor[7] = 1;
                    if (panel9.Visible == true) contor[8] = 1;
                }
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (rand[0] == false && rand[1] == false && rand[2] == false)
            {
                if (contor[9] == 1 && contor[10] == 1 && contor[11] == 1 && contor[12] == 1 && contor[13] == 1 && contor[14] == 1 && contor[15] == 1)
                {
                    panel10.BackColor = Color.Transparent;
                    panel11.BackColor = Color.Transparent;
                    panel12.BackColor = Color.Transparent;
                    panel13.BackColor = Color.Transparent;
                    panel14.BackColor = Color.Transparent;
                    panel15.BackColor = Color.Transparent;
                    panel16.BackColor = Color.Transparent;
                    contor[9] = 0; contor[10] = 0; contor[11] = 0; contor[12] = 0; contor[13] = 0; contor[14] = 0; contor[15] = 0;
                    rand[3] = false;
                }
                else
                {
                    if (first[0] == true)
                    {
                        panel10.BackgroundImage = null;
                        panel10.BackColor = Color.LimeGreen;
                        panel11.BackgroundImage = null;
                        panel11.BackColor = Color.LimeGreen;
                        panel12.BackgroundImage = null;
                        panel12.BackColor = Color.LimeGreen;
                        panel13.BackgroundImage = null;
                        panel13.BackColor = Color.LimeGreen;
                        panel14.BackgroundImage = null;
                        panel14.BackColor = Color.LimeGreen;
                        panel15.BackgroundImage = null;
                        panel15.BackColor = Color.LimeGreen;
                        panel16.BackgroundImage = null;
                        panel16.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        panel10.BackgroundImage = null;
                        panel10.BackColor = Color.Red;
                        panel11.BackgroundImage = null;
                        panel11.BackColor = Color.Red;
                        panel12.BackgroundImage = null;
                        panel12.BackColor = Color.Red;
                        panel13.BackgroundImage = null;
                        panel13.BackColor = Color.Red;
                        panel14.BackgroundImage = null;
                        panel14.BackColor = Color.Red;
                        panel15.BackgroundImage = null;
                        panel15.BackColor = Color.Red;
                        panel16.BackgroundImage = null;
                        panel16.BackColor = Color.Red;
                    }
                    rand[3] = true;
                    if (panel10.Visible == true) contor[9] = 1;
                    if (panel11.Visible == true) contor[10] = 1;
                    if (panel12.Visible == true) contor[11] = 1;
                    if (panel13.Visible == true) contor[12] = 1;
                    if (panel14.Visible == true) contor[13] = 1;
                    if (panel15.Visible == true) contor[14] = 1;
                    if (panel16.Visible == true) contor[15] = 1;
                }
            }
        }
        //
        //
        //
        //
    }
}
