using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace bmiкалькулятор
{
    public partial class Form1 : Form
    {
        double BMI;
        double r;
        double V;
        public Form1()
        {
            InitializeComponent();
        }
        private void Мужской_Click(object sender, EventArgs e)
        {
            woman.BorderStyle = BorderStyle.None;
            man.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.Gainsboro;
            woman.BackColor = Color.WhiteSmoke;
        }

        private void Женский_Click(object sender, EventArgs e)
        {
            man.BorderStyle = BorderStyle.None;
            woman.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.WhiteSmoke;
            woman.BackColor = Color.Gainsboro;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Рассчитать_Click(object sender, EventArgs e)
        {
            r = float.Parse(rost.Text);
            V = float.Parse(ves.Text);
            r = r / 100;
            BMI = V / (r * r);
            itog.Text = Convert.ToString(BMI);
            itog.Text = BMI.ToString("N");
            if (BMI <= 18.5 && BMI >= 10){picture.Image = Properties.Resources.bmi_underweight_icon;trackBar1.Value = 10;diagnoz.Text = "Недовес"; }
            else if (BMI > 18.5 && BMI <= 24.9){picture.Image = Properties.Resources.bmi_healthy_icon;trackBar1.Value = 15;diagnoz.Text = "Здоровый";}
            else if (BMI <= 30 && BMI > 24.9){picture.Image = Properties.Resources.bmi_overweight_icon;trackBar1.Value = 25;diagnoz.Text = "Избыточный вес";}
            else if (BMI > 30 && BMI < 35){picture.Image = Properties.Resources.bmi_obese_icon;trackBar1.Value = 35;diagnoz.Text = "Ожирение";}
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void itog_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            rost.Clear();
            ves.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void diagnoz_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Map MyForm2 = new Map();
            MyForm2.ShowDialog();
            Close();
        }
    }
}
