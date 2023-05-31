using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace текстовый_редактор
{
    public partial class Form1 : Form
    {
        static string open_path = "";
        static string filename = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename2 = openFileDialog1.FileName;
            string text = File.ReadAllText(filename2);
            richTextBox1.Text = text;
            open_path = filename2;
            string path = File.ReadAllText("files/path.t$");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }//Проверяем был ли выбран файл
         
        }

        private void button9_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251

                richTextBox1.Clear();
            } 
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void слеваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select(); // выравнивание только выделенного текста
            richTextBox1.SelectAll(); //выделение всего текста
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox1.DeselectAll(); //Отмена выделения

        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select(); // выравнивание только выделенного текста
            richTextBox1.SelectAll(); //выделение всего текста
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll(); //Отмена выделения
        }

        private void справаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select(); // выравнивание только выделенного текста
            richTextBox1.SelectAll(); //выделение всего текста
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.DeselectAll(); //Отмена выделения
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void настройкаПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = File.ReadAllText("files/path.t$");
                if (open_path != "")
                {
                    File.WriteAllText(open_path, richTextBox1.Text);
                }
                else
                {
                    MessageBox.Show(
                        "Error!",
                        "Файл не сохранён",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Файл не сохранён",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            richTextBox1.Cut();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }
    }
}
