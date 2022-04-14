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
    public partial class Analyz2 : Form
    {
        int sum;
        public Analyz2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Analyz2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("18-29");
            comboBox1.Items.Add("30-39");
            comboBox1.Items.Add("40-49");
            comboBox1.Items.Add("50-59");
            comboBox1.Items.Add("60-69");
            comboBox1.Items.Add("70-79");
            comboBox1.Items.Add("80 и выше");

            comboBox2.Items.Add("Мужской");
            comboBox2.Items.Add("Женский");

            comboBox3.Items.Add("Да");
            comboBox3.Items.Add("Нет");

            comboBox4.Items.Add("1,5–3км/ден.");
            comboBox4.Items.Add("1,5–3км/нед.");
            comboBox4.Items.Add("<1,5–3км/нед.");

            comboBox5.Items.Add("Не употребляю");
            comboBox5.Items.Add("1-2 раз/нед.");
            comboBox5.Items.Add("1-2 раз/мес.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double BestVes = 0;
            sum = 0;
            int ratrate = 0;

            if (comboBox1.SelectedIndex == 0)
                sum += 0;
            if (comboBox1.SelectedIndex == 1)
                sum += 1;
            if (comboBox1.SelectedIndex == 2)
                sum += 2;
            if (comboBox1.SelectedIndex == 3)
                sum += 3;
            if (comboBox1.SelectedIndex == 4)
                sum += 4;
            if (comboBox1.SelectedIndex == 5)
                sum += 5;
            if (comboBox1.SelectedIndex == 6)
                sum += 6;

            if (comboBox2.SelectedIndex == 0)
                sum += 1;
            if (comboBox2.SelectedIndex == 1)
                sum += 0;

            if (comboBox3.SelectedIndex == 0)
                sum += 2;
            if (comboBox3.SelectedIndex == 1)
                sum += 0;

            if (comboBox4.SelectedIndex == 0)
                sum += 0;
            if (comboBox4.SelectedIndex == 1)
                sum += 1;
            if (comboBox4.SelectedIndex == 2)
                sum += 2;

            if (comboBox5.SelectedIndex == 0)
                sum += 0;
            if (comboBox5.SelectedIndex == 1)
                sum += 2;
            if (comboBox5.SelectedIndex == 2)
                sum += 1;

            int rost = Convert.ToInt32(textBox1.Text);
            int ves = Convert.ToInt32(textBox2.Text);
            if (rost <= 165)
            BestVes = (double) rost - 100.0;
            if (rost > 165 && rost <= 175)
            BestVes = (double) rost - 105.0;
            if (rost > 175)
            BestVes = (double) rost - 110.0;
            if ((double) ves > BestVes * 1.1 || (double) ves <BestVes*0.9)
                sum += 1;

            if (checkBox1.Checked == true)
                sum += 1;
            if (checkBox2.Checked == true)
                sum += 2;
            if (checkBox3.Checked == true)
                sum += 2;
            if (checkBox4.Checked == true)
                sum += 1;
            if (checkBox5.Checked == true)
                sum += 2;
            if (checkBox6.Checked == true)
                sum += 2;
            if (checkBox7.Checked == true)
                sum += 3;
            if (checkBox8.Checked == true)
                sum += 2;
            if (checkBox9.Checked == true)
                sum += 3;
            if (checkBox10.Checked == true)
                sum += 4;
            if (checkBox11.Checked == true)
                sum += 4;
            if (checkBox12.Checked == true)
                sum += 2;
            if (checkBox13.Checked == true)
                sum += 5;
            if (checkBox14.Checked == true)
                sum += 3;


            if (checkBox15.Checked == true)
                ratrate += 1;
            if (checkBox16.Checked == true)
                ratrate += 1;
            if (checkBox17.Checked == true)
                ratrate += 1;
            if (checkBox18.Checked == true)
                ratrate += 1;
            if (checkBox19.Checked == true)
                ratrate += 1;
            if (checkBox20.Checked == true)
                ratrate += 1;

            if (ratrate <= 2)
                sum += 2;
            if (ratrate > 2 && ratrate <= 4)
                sum += 1;
            if (ratrate > 4)
                sum += 0;

            if (checkBox21.Checked == true)
                sum += 1;
            if (checkBox22.Checked == true)
                sum += 2;
            if (checkBox23.Checked == true)
                sum += 2;
            if (checkBox24.Checked == true)
                sum += 2;
            if (checkBox25.Checked == true)
                sum += 3;
            if (checkBox26.Checked == true)
                sum += 3;

            if (sum >= 46)
                MessageBox.Show("                                        " +
                    "Сумма баллов: " + sum + "\n      " +
                    "Опасность сердечнососудистых заболеваний: Высокая.\n\n" +
                    "Вам необходимо срочно обратится к участковому врачу для проведения комплексного обследования и назначения лечения.\n" +
                    "При необходимости Вас направят на консультацию к кардиологу или кардиохирургу");
            if (sum < 46 && sum >= 31)
            MessageBox.Show("                                        " +
    "Сумма баллов: " + sum + "\n      " +
    "Опасность сердечнососудистых заболеваний: Выраженная.\n\n" +
    "Ваше здоровье нуждается в безотлагательной медицинской коррекции.\n" +
    "Вам следует обратится к участковому врачу для совместно выработки программы реабилитации");
            if (sum < 30 && sum >= 16)
                MessageBox.Show("                                        " +
        "Сумма баллов: " + sum + "\n      " +
        "Опасность сердечнососудистых заболеваний: Умеренная.\n\n" +
        "Ваше здоровье находится в состоянии хрупкого равновесия, так как пребывает под давлением неблагоприятных факторов" +
        ". В Ваших силах сохранить и преумножить Ваше здоровье." +
        " Откажитесь от вредных привычек, упорядочьте режим дня, займитесь физкультурой и спортом, чаще бывайте на воздухе.");

            if (sum < 16)
                MessageBox.Show("                                        " +
        "Сумма баллов: " + sum + "\n      " +
        "Опасность сердечнососудистых заболеваний: Отсутствует.\n\n" +
        "Ваше здоровье не вызывает опасений. Вам удается успешно избегать факторы, способные привести заболеванию");
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            Main.Show();
            Hide();
        }
    }
}
