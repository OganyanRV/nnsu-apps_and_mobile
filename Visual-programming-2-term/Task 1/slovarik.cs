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


namespace WindowsFormsApp1
{

    public partial class Slovarik : Form

    {
        bool rejim = true;
        public Slovarik()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "Русский";
            label2.Text = "Английский";
            button1.Text = "ПЕРЕВЕСТИ";
            rejim = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "English";
            label2.Text = "Russian";
            button1.Text = "TRANSLATE";
            rejim = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rejim) // если введенное слово на английском
            {
                string[] textENG = File.ReadAllLines("EnRuDict.dat", Encoding.Default); //Считывание файла в массив строк
                string slovoEng = textBox1.Text; // Введенное слово
                // Поиск введенного слова в файле
                for (int i = 0; i < textENG.Length; i++)
                {

                    if (textENG[i].IndexOf(slovoEng) == 0)
                    {
                        string russlovoEng = textENG[i].Remove(0, slovoEng.Length + 1);
                        if (russlovoEng[0] >= 'А' && russlovoEng[0] <= 'я') //костыль
                        {
                            textBox2.Text = russlovoEng;
                            break;
                        }

                    }
                    else textBox2.Text = "Такого слова нет в словаре";

                }
            }
            else // если введенное слово на русском
            {
                string[] textRUS = File.ReadAllLines("RuEnDict.dat", Encoding.Default);
                string slovoRus = textBox1.Text;
                for (int i = 0; i < textRUS.Length; i++)
                {
                    if (textRUS[i].IndexOf(slovoRus) == 0)
                    {
                        string englslovoRus = textRUS[i].Remove(0, slovoRus.Length + 1);
                        if (englslovoRus[0] >= 'A' && englslovoRus[0] <= 'z')
                        {
                            textBox2.Text = englslovoRus;
                            break;
                        }

                    }
                    else textBox2.Text = "Такого слова нет в словаре";

                }
            }
        }

        private void Slovarik_Load(object sender, EventArgs e)
        {

        }
    }


}
