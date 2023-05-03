using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmiкалькулятор
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            panel1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "Финиш";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label1.Text = "\nСтадион Лужники";
            label2.Text = "\nОсобенности:" +
                "\n-Стенд для питья" +
                "\n-Энергетические  батончики" +
                "\n\n-Туалет" +
                "\n-Медецинский пункт" +
                "\n-Информация";
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label1.Text = "МЦК Лужники";
            label2.Text = "Особенности:" +
                "\n\n-Стенд для питья" +
                "\n-Энергетические батончики";
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label1.Text = "\nНоводевичей " +
                "монастырь";
            label2.Text = "\nОсобенности:" +
               // "\n" +
                "\n-Стенд для питья" +
                "\n-Энергетические  батончики" +
                "\n" +
                "\n-Туалет\n" +
                "-Медецинский пункт" +
                "\n" +
                "-Информация";
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label1.Text = "\nМетро Киевская";
            label2.Text = "\nОсобенности:" +
                "\n-Стенд для питья" +
                //"\n" +
                "\n-Энергетические батончики" +
                //"\n" +
                "\n-Туалет";
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = true;
            pictureBox18.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label1.Text = "\nМИД";
            label2.Text = "\nОсобенности:" +
                "\n-Стенд для питья" +
                "\n-Энергетические батончики" +
                "\n-Туалет";
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = true;
            pictureBox18.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label1.Text = "\nПарк Горького";
            label2.Text = "\nОсобенности:" +
                "\n-Стенд для питья" +
                "\n-Энергетические батончики" +
                "\n-Туалет" +
                "\n\n\n\n-Информация";
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label1.Text = "\nЗдания РАН";
            label2.Text = "\nОсобенности:" +
                "\n-Стенд для питья" +
                "\n-Энергетические батончики" +
                "\n-Туалет";
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = true;
            pictureBox18.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label1.Text = "\nМетро Воробевы горы";
            label2.Text = "\nОсобенности:" +
                "\n-Стенд для питья" +
                "\n-Энергетические  батончики" +
                "\n\n-Туалет" +
                "\n-Медецинский пункт" +
                "\n-Информация";
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = false;
           
            label1.Text = "Старт";
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = false;

            label1.Text = "Старт";
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = false;

            label1.Text = "Старт";
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }
    }
}
