using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace KutuphaneProjesi
{
    public partial class menu : Form
    {
        SqlConnection con = new SqlConnection(); // bağlantı işlemlerini yapacağımız sınıftan obje aldık.
        kullanicibilgileri kulbilgi = new kullanicibilgileri();
        List<kullanicibilgileri> kulliste = new List<kullanicibilgileri>(); // Kisi türünde obje tutan bir list tanımladık.
        List<kitapbilgileri> kitapliste = new List<kitapbilgileri>();
        public void listele()
        {
            con.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from kitap";
            komut.Connection = con;
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) // satır satır kayıtları okuduk (bir sürü kayıt var, sırayla gelen satırı objemizde tutup listeye ekleyeceğiz)
            {
                kitapbilgileri kitap = new kitapbilgileri();
                kitap.kitapid = Convert.ToInt32(dr["kitapid"]); //gelen kayıdın sütunlarını ayırıp objemizin ilgili alanlarında tutuyoruz
                kitap.kitapadı = dr["kitapadi"].ToString();
                kitap.kitapturu = Convert.ToInt32(dr["kitapturid"]);
                kitap.kitapevi = Convert.ToInt32(dr["kitapevid"]);
                kitap.sayfa = dr["sayfa"].ToString();

                kitapliste.Add(kitap); 
            }

            kitapdatagrid = null;
            kitapdatagrid = kitapliste;
            con.Close();

        }
        public menu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            if (kulbilgi.yetkili == false)
            {
                groupBox1.Hide();
                groupBox2.Hide();
            }
            else
            {
                MessageBox.Show("Admin Girişi Yapıldı");
            }
        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            if (txt_kitapad.Text == "" && txt_kitapturu.Text == "" && txt_kitapevi.Text == "" && txt_sayfa.Text == "")
            {
                MessageBox.Show("boş alan bırakmayınız!");
            }
            else
            {
                con.Open();
                kitapbilgileri kitap = new kitapbilgileri();
                kitap.kitapadı = txt_kitapad.Text;
                kitap.kitapturu = int.Parse(txt_kitapturu.Text);
                kitap.kitapevi = int.Parse(txt_kitapevi.Text);
                kitap.sayfa = txt_sayfa.Text;
                kitapliste.Add(kitap);


                SqlCommand komut = new SqlCommand();
                komut.CommandText = "insert into Kisi values(@p1,@p2,@p3,@p4)"; // objede tuttuğumuz verileri database e yani veritabanına parametreler ile gönderiyoruz ki güvenlik açığı olmasın
                komut.Parameters.AddWithValue("@p1", kitap.kitapadı);
                komut.Parameters.AddWithValue("@p2", kitap.kitapturu);
                komut.Parameters.AddWithValue("@p3", kitap.kitapevi);
                komut.Parameters.AddWithValue("@p4", kitap.sayfa);
                komut.Connection = con;
                komut.ExecuteNonQuery();
                con.Close();

            }
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            if (kitapdatagrid.SelectedRows.Count == 1)
            {
                kitapbilgileri kitap = (kitapbilgileri)kitapdatagrid.SelectedRows[0].DataBoundItem;
                con.Open();
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "delete from kitap where kitapid=" + kitap.kitapid; 
                komut.Connection = con;
                komut.ExecuteNonQuery();
            }
        }
    }
}
