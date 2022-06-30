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
            label1.Text = "�������";
            label2.Text = "����������";
            button1.Text = "���������";
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
            if (rejim) // ���� ��������� ����� �� ����������
            {
                string[] textENG = File.ReadAllLines("EnRuDict.dat", Encoding.Default); //���������� ����� � ������ �����
                string slovoEng = textBox1.Text; // ��������� �����
                // ����� ���������� ����� � �����
                for (int i = 0; i < textENG.Length; i++)
                {

                    if (textENG[i].IndexOf(slovoEng) == 0)
                    {
                        string russlovoEng = textENG[i].Remove(0, slovoEng.Length + 1);
                        if (russlovoEng[0] >= '�' && russlovoEng[0] <= '�') //�������
                        {
                            textBox2.Text = russlovoEng;
                            break;
                        }

                    }
                    else textBox2.Text = "������ ����� ��� � �������";

                }
            }
            else // ���� ��������� ����� �� �������
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
                    else textBox2.Text = "������ ����� ��� � �������";

                }
            }
        }

        private void Slovarik_Load(object sender, EventArgs e)
        {

        }
    }


}
