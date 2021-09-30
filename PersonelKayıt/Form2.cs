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

namespace PersonelKayıt
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            con = new SqlConnection("Data Source = TRALPC5039; Initial Catalog = PersonelKayıtDB; User ID = sa; Password = @limex2017");//Kullanıcı adı ve şifreyi veri tabanından aldığımız için öncelikle sql bağlantımızı bir değişkene atıyoruz.
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM LoginTbl where [User]='" + txtUser.Text + "' AND PassWord='" + txtPass.Text + "'";//Kullanıcı adı ve şifremizi SQL tablomuzdan seçiyoruz.
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //Eğer kullanıcı adı ve şifremiz doğru ise Form1'i yani Personel kayıt uygulamıza giriş yapıyoruz.
                Form1 frm = new Form1();
                frm.Show();
                this.Close();     
                
                 
            }
            else
            {
                //yanlış olma durumunda kullanıcıya uyarı veriyoruz.
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();//Çıkış butonuna basıldığında progmamımızın çalışmasını duruduruyoruz.
        }

         
    }
}
