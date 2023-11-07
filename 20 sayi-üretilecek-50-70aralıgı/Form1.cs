using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_sayi_üretilecek_50_70aralıgı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd=new Random();
            for(int i=1; i<100; i++)
            {
                listBox1.Items.Add(rnd.Next(1,101));
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
         for (int i=0; i<listBox1.Items.Count; i++)
            {
                int sayi = Convert.ToInt32(listBox1.Items[i]);
                if(sayi>=50 && sayi <= 70)
                {
                    listBox2.Items.Add(sayi);
                }
            }

        }
    }
}
