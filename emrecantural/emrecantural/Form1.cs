using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emrecantural
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Dictionary<string, int> SonucListesi = new Dictionary<string, int>();
            
            string Txt = textBox1.Text;
            List<char> AlfabeListesi = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ".ToCharArray().ToList();
            foreach (char Harf in AlfabeListesi)
            {
                string TxtTxt = Txt.ToUpper();
                int Sayi = 0;
                while (TxtTxt.Length > 0)
                {
                    int deger = TxtTxt.IndexOf(Harf);
                    if (deger > -1)
                    {
                        Sayi++;
                        int Bas = deger + 1;
                        int Bit = ((TxtTxt.Length - deger) - 1);
                        if (Bit > -1)
                        {
                            TxtTxt = TxtTxt.Substring(Bas, Bit);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        TxtTxt = "";
                    }
                }
                if (Sayi > 0)
                {
                    SonucListesi.Add(Harf.ToString(), Sayi);
                }
            }
            
            foreach (var Sonuc in SonucListesi)
            {
                listBox1.Items.Add(string.Format("{0} Karakteri {1} tanedir", Sonuc.Key, Sonuc.Value));
            }
            Console.ReadLine();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
