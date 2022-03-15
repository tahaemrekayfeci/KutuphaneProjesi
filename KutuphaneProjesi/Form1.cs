using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        kullanicibilgileri kulbilgi = new kullanicibilgileri();
        
        private void btn_giris_Click(object sender, EventArgs e)
        {
            kulbilgi.ad = txt_kulad.text;
            kulbilgi.sifre = txt_sifre.text;
            if (kulbilgi.ad == "Yetkili")
            {
                if (kulbilgi.sifre == "evyap1234")
                {
                    kulbilgi.yetkili = true;
                    menu m = new menu();
                    
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifreniz Yanlış!");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız Yanlıştır !");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
