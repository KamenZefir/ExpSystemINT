using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpSystemINT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Определение опасности развития ССЗ");
            comboBox1.Items.Add("Риск развития заболеваний гастродуоденальной зоны");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Analyz2 Analyz_2 = new Analyz2();
                Analyz_2.Show();
                Hide();

            }
            if (comboBox1.SelectedIndex == 1)
            {
                Analyz1 Analyz_1 = new Analyz1();
                Analyz_1.Show();
                Hide();
            }
        }
    }
}
