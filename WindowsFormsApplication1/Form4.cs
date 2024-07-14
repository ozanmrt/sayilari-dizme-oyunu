﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        Point bos;
        int sayac = 0;
        int oyuncu = 1;
        Point[] noktalar = new Point[16] {
            new Point(0,0),
            new Point(100,0),
            new Point(200,0),
            new Point(300,0),

            new Point(0,100),
            new Point(100,100),
            new Point(200,100),
            new Point(300,100),

            new Point(0,200),
            new Point(100,200),
            new Point(200,200),
            new Point(300,200),

            new Point(0,300),
            new Point(100,300),
            new Point(200,300),
            new Point(300,300),
        };

        void dagit()
        {
            noktalar = Shuffle<Point>(noktalar);
            button1.Location = noktalar[0];
            button2.Location = noktalar[1];
            button3.Location = noktalar[2];
            button4.Location = noktalar[3];
            button5.Location = noktalar[4];
            button6.Location = noktalar[5];
            button7.Location = noktalar[6];
            button8.Location = noktalar[7];
            button9.Location = noktalar[8];
            button10.Location = noktalar[9];
            button11.Location = noktalar[10];
            button16.Location = noktalar[11];
            button13.Location = noktalar[12];
            button14.Location = noktalar[13];
            button15.Location = noktalar[14];
            bos = noktalar[15];
        }

        bool komsumu(Point kutu)
        {
            if (kutu.X == bos.X || kutu.Y == bos.Y)
            {
                if (Math.Abs(kutu.X - bos.X) <= 100 && Math.Abs(kutu.Y - bos.Y) <= 100)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        private T[] Shuffle<T>(T[] noktalar)
        {
            Random rs = new Random();
            for (int i = noktalar.Length; i > 1; i--)
            {
                // Pick random element to swap.
                int j = rs.Next(i); // 0 <= j <= i-1
                                    // Swap.
                T tmp = noktalar[j];
                noktalar[j] = noktalar[i - 1];
                noktalar[i - 1] = tmp;
            }
            return noktalar;
        }


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            dagit();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            yerDegistir(10, button11);
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yerDegistir(0, button1);
        }

        private void yerDegistir(int no, Button dugme)
        {
            if (komsumu(noktalar[no]))
            {
                dugme.Location = degistir(noktalar[no]);
                Point gecici = noktalar[15];
                noktalar[15] = noktalar[no];
                noktalar[no] = gecici;
                sayac++;
                label1.Text = "";
                label2.Text = "Yapılan Hamle Sayısı: " + sayac;

            }
            else
            {
                label1.Text = "Geçersiz Hamle !";
            }

            oyunBittiMi();
        }

        Point degistir(Point kutu)
        {
            Point gecici = bos;
            bos.X = kutu.X;
            bos.Y = kutu.Y;
            return gecici;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yerDegistir(1, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yerDegistir(2, button3);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            yerDegistir(3, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yerDegistir(4, button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            yerDegistir(5, button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            yerDegistir(6, button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            yerDegistir(7, button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            yerDegistir(8, button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            yerDegistir(9, button10);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            yerDegistir(11, button16);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            yerDegistir(12, button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            yerDegistir(13, button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            yerDegistir(14, button15);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            dagit();
            sayac = 0;
            label1.Text = "";
            label2.Text = "Yapılan Hamle Sayısı: " + sayac;
        }

        private void oyunBittiMi()
        {

            bool bittmi = true;

            if (noktalar[0] != new Point(0, 0))
            {
                bittmi = false;
            }

            if (noktalar[1] != new Point(100, 0))
            {
                bittmi = false;
            }
            if (noktalar[2] != new Point(200, 0))
            {
                bittmi = false;
            }

            if (noktalar[3] != new Point(300, 0))
            {
                bittmi = false;
            }



            if (noktalar[4] != new Point(0, 100))
            {
                bittmi = false;
            }

            if (noktalar[5] != new Point(100, 100))
            {
                bittmi = false;
            }
            if (noktalar[6] != new Point(200, 100))
            {
                bittmi = false;
            }

            if (noktalar[7] != new Point(300, 100))
            {
                bittmi = false;
            }



            if (noktalar[8] != new Point(0, 200))
            {
                bittmi = false;
            }

            if (noktalar[9] != new Point(100, 200))
            {
                bittmi = false;
            }
            if (noktalar[10] != new Point(200, 200))
            {
                bittmi = false;
            }

            if (noktalar[11] != new Point(300, 200))
            {
                bittmi = false;
            }



            if (noktalar[12] != new Point(0, 300))
            {
                bittmi = false;
            }

            if (noktalar[13] != new Point(100, 300))
            {
                bittmi = false;
            }
            if (noktalar[14] != new Point(200, 300))
            {
                bittmi = false;
            }

            if (noktalar[15] != new Point(300, 300))
            {
                bittmi = false;
            }


            if (bittmi == true)
            {
                MessageBox.Show("Tebrikler " + sayac + " Hamlede Bitirdiniz.");
                dagit();


                listBox1.Items.Add(oyuncu + ". Oyun " + sayac + " Hamlede Bitti.");
                oyuncu++;

                sayac = 0;
                label1.Text = "";
                label2.Text = "Yapılan Hamle Sayısı: " + sayac;

            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
                      

        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            oyuncu = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                panel1.Visible = false;
                pictureBox1.Visible = true;

                button17.Visible = false;
                button18.Visible = false;
                button12.Visible = false;

                label1.Visible = false;
                label2.Visible = false;
                listBox1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
                pictureBox1.Visible = false;

                button17.Visible = true;
                button18.Visible = true;
                button12.Visible = true;

                label1.Visible = true;
                label2.Visible = true;
                listBox1.Visible = true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
