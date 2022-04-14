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
    public partial class Analyz1 : Form
    {
        public Analyz1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            Main.Show();
            Hide();
        }

        private void Analyz1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("До 45");
            comboBox1.Items.Add("45-54");
            comboBox1.Items.Add("55-64");
            comboBox1.Items.Add("Старше 65");

            comboBox2.Items.Add("Мужчины");
            comboBox2.Items.Add("Женщины");

            comboBox3.Items.Add("Да, ежедневно употребляю");
            comboBox3.Items.Add("Нет, употребляю редко");

            comboBox4.Items.Add("Да, регулярно занимаюсь");
            comboBox4.Items.Add("Нет, занимаюсь редко");

            comboBox6.Items.Add("Нет, не принимал");
            comboBox6.Items.Add("Да, принимал");

            comboBox7.Items.Add("Нет");
            comboBox7.Items.Add("Да");

            comboBox8.Items.Add("Нет");
            comboBox8.Items.Add("Да: дедушка/бабушка, тетя/дядя/двоюродные братья/сестры");
            comboBox8.Items.Add("Да: родители, брат/сестра, ребенок");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (comboBox1.SelectedIndex == 0)
                sum += 0;
            if (comboBox1.SelectedIndex == 1)
                sum += 2;
            if (comboBox1.SelectedIndex == 2)
                sum += 3;
            if (comboBox1.SelectedIndex == 3)
                sum += 4;

            double rost = Convert.ToDouble(textBox1.Text);
            double ves = Convert.ToDouble(textBox2.Text);
            double imt;
            imt = ves / Math.Pow(rost, 2);

            if (imt >= 25 && imt <= 30)
            {
                sum += 1;
            }
            if (imt >= 25 && imt <= 30)
                sum += 1;

            if (imt > 30)
                sum += 3;

            if (comboBox5.SelectedIndex == 0)
                sum += 0;
            if (comboBox5.SelectedIndex == 1)
                sum += 3;
            if (comboBox5.SelectedIndex == 2)
                sum += 4;

            if (comboBox3.SelectedIndex == 0)
                sum += 0;
            if (comboBox3.SelectedIndex == 1)
                sum += 1;

            if (comboBox4.SelectedIndex == 0)
                sum += 0;
            if (comboBox4.SelectedIndex == 1)
                sum += 2;

            if (comboBox6.SelectedIndex == 0)
                sum += 0;
            if (comboBox6.SelectedIndex == 1)
                sum += 2;

            if (comboBox7.SelectedIndex == 0)
                sum += 0;
            if (comboBox7.SelectedIndex == 1)
                sum += 5;

            if (comboBox8.SelectedIndex == 1)
                sum += 3;
            if (comboBox8.SelectedIndex == 2)
                sum += 5;


            if (sum > 20)
                MessageBox.Show("                                        " +
                    "Сумма баллов: " + sum + "\n      " +
                    "Риск развития сахарного диабета: Очень высокий.\n\n" +
                    "По всей вероятности, у Вас есть сахарный диабет 2 типа. " +
                    "Вы должны проверить уровень глюкозы (сахара) крови и постараться его нормализовать." +
                    "Вы должны изменить свой образ жизни и Вам понадобятся и лекарства для контроля уровня глюкозы (сахара) в крови.");
            if (sum >= 15 && sum <= 20)
                MessageBox.Show("                                        " +
        "Сумма баллов: " + sum + "\n      " +
        "Риск развития сахарного диабета: Высокий.\n\n" +
        "Возможно у Вас предиабет или сахарный диабет 2 типа. Вам желательно проверить уровень глюкозы (сахара) в крови." +
        " Вы должны изменить свой образ жизни. " +
        "Не исключено, что Вам понадобятся и лекарства для снижения уровня глюкозы (сахара) в крови.");
            if (sum >= 12 && sum <= 14)
                MessageBox.Show("                                        " +
        "Сумма баллов: " + sum + "\n      " +
        "Риск развития сахарного диабета: Умеренный.\n\n" +
        "Возможно, у вас предиабет. Вы должны посоветоваться со своим врачом, как Вам следует изменить образ жизни.");

            if (sum >= 7 && sum <= 14)
                MessageBox.Show("                                        " +
        "Сумма баллов: " + sum + "\n      " +
        "Опасность сердечнососудистых заболеваний: Слегка повышен.\n\n" +
        "Вас хорошее здоровье и Вы должны продолжать вести здоровый образ жизни.");

            if (sum >= 7 && sum <= 11)
                MessageBox.Show("                                        " +
        "Сумма баллов: " + sum + "\n      " +
        "Опасность сердечнососудистых заболеваний: Слегка повышен.\n\n" +
        "Вас хорошее здоровье и Вы должны продолжать вести здоровый образ жизни.");

            if (sum < 7)
                MessageBox.Show("                                        " +
        "Сумма баллов: " + sum + "\n      " +
        "Опасность сердечнососудистых заболеваний: Минимальный.\n\n" +
        "Вас хорошее здоровье и Вы должны продолжать вести здоровый образ жизни.");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.ResetText();
            comboBox5.Items.Clear();

            if (comboBox2.SelectedIndex == 0)
            {
                comboBox5.Items.Add("< 94");
                comboBox5.Items.Add("94 - 102");
                comboBox5.Items.Add("> 102");
            }
            if (comboBox2.SelectedIndex == 1)
            {
                comboBox5.Items.Add("< 80");
                comboBox5.Items.Add("80 - 88");
                comboBox5.Items.Add("> 88");
            }
        }
    }
}
