using lab1;
using System;
using System.Collections.Generic;

namespace gui
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void UpdateTextBox()
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string n = textBox1.Text;
            string seed = textBox2.Text;
            string capacity = textBox3.Text;

            //string na int
            int ni, seedi, capacityi;
            if (!int.TryParse(n, out ni) || !int.TryParse(seed, out seedi) || !int.TryParse(capacity, out capacityi))
            {
                MessageBox.Show("Podano nieprawid³owe wartoœci dla n, seed lub capacity.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            Problem problem = new Problem(ni, seedi);
            Result result = problem.Solve(capacityi);


            richTextBox1.Text = result.ToString();
            richTextBox2.Text = problem.ToString();
           
            //zabezpieczenie na litery

        }
    }
}
