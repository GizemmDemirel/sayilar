using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayi = { 12,34,45,56,67,89,98};
        string[] sehirler = {" istanbul","ankara","mugla","antalya" };
        int[] sayilar = new int [50];
        Random ratgele=new Random();
     
        private void button1_Click(object sender, EventArgs e)
        {
            Array.Sort(sayi);
            listBox1.Items.Clear();  
            for (int i = 0; i < sayi.Length; i++)
            {
                listBox1.Items.Add(sayi[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Reverse(sayi);
            listBox1.Items.Clear();
            for (int i = 0;i <sayi.Length; i++)
            {
                listBox1.Items.Add(sayi[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "En Büyük Sayı" + sayi.Max().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "En Küçük Sayı" + sayi.Min().ToString();
        }
      
        private void button6_Click(object sender, EventArgs e)
        {
            label6.Text = sehirler[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {
           label5.Text=sehirler[sehirler.Length-1];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < sayilar.Length; i++)
            {
               sayilar[i] = ratgele.Next(0,20);
               listBox1.Items.Add(i+1 +" )" +sayilar[i]);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "toplam sayi= " + sayi.Sum().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Array.Sort(sayilar);
            listBox1.Items.Clear();
            for (int i = 0; i < sayilar.Length;i++)
            {
                listBox1.Items.Add(sayilar[i]);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Array.Reverse(sayilar);
            listBox1.Items.Clear();
            for (int i = 0; i < sayilar.Length; i++)
            {
                listBox1.Items.Add(sayilar[i]);
            }
        }


       
        }

       
         
            
        }
   


