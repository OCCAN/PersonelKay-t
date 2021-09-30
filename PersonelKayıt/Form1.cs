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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TRALPC5039;Initial Catalog=PersonelKayıtDB;User ID=sa;Password=@limex2017"); //sql bağlantısını bir değişkene atıyoruz.
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            this.bolumTblTableAdapter.Fill(this.personelKayıtDBDataSet2.BolumTbl);//combobox'a veri attığımız için otomatik gelen kod.
            
            EslemeFonk(); //Uygulama açıldığında çalışır çalışmaz datagridview'da listelenmesi için hazırladığımız fonksiyonu burada çağırıyoruz.
            
            
        }

        private void ListeleBtn_Click(object sender, EventArgs e)
        {
            EslemeFonk(); //Listele butonuna basıldığında listelemesi için fonksiyonumuzu çağırıyoruz. 
        }

        void EslemeFonk()//Bu fonksiyonu ayrı olarak yazmamızın sebebi diğer butonlara basıldığında eklenen, güncellenen yahut siinen personellerin değişiklikleri işlemi yapar yapmaz tabloda görmek.
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT p.Personel_ID, p.Ad, p.Soyad, p.DogumTarihi, p.GirisTarihi, b.BolumIsmi FROM PersonelTbl p INNER JOIN BolumTbl b ON p.Bolum_ID = b.Bolum_ID ", baglanti); //INSERT komutunu kullanarak SQL'de oluşturduğumuz iki tablodan istediğim verileri götermek için yazılan komut.
            //SQL tablomuzu dataGridView'a doldurmamızı sağlayan kodlar;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        
	

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into PersonelTbl (Ad, Soyad, DogumTarihi, GirisTarihi, Bolum_ID) values(@p1, @p2, @p3, @p4 ,@p5)", baglanti);//INSERT komutu kullanılarak textBox'a yazdığımız, DateTimePicker'da seçtiğimiz ve combobox'ta seçtiğimiz verilerin SQL tablomuza kaydediyoruz.
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", BirthDayPicker.Value);
            komut.Parameters.AddWithValue("@p4", JoinDayPicker.Value);
            komut.Parameters.AddWithValue("@p5", cmbDepartment.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi.");
            EslemeFonk();
        }

        
        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //CellDoubleClick Event'i dataGridView'da listelenen personellerden herhangi birine çift tıklandığında, üstünde bulunan boş kısımların doldurulmasına yarıyor. Böylelikle güncelleme ve silme işlemini daha kolay yapabiliyoruz.
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            BirthDayPicker.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            JoinDayPicker.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            cmbDepartment.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            EslemeFonk();
            
        }
        
        private void SilBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete from PersonelTbl Where Personel_ID = @p1", baglanti);//DELETE komutu sayesinde doubleClick event ile seçtiğimiz personeli Sil butonu ile silebiliyoruz.
            sil.Parameters.AddWithValue("@p1", textBox1.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Silindi.");
            EslemeFonk();
        }

        private void GüncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update PersonelTbl Set Ad=@p1, Soyad=@p2, DogumTarihi=@p3, GirisTarihi=@p4, Bolum_ID=@p5 where Personel_ID = @p6", baglanti);// Update komutu sayesinde seçili personelde yapacğımız işlemleri seçtikten sonra yukarıdaki kısımdan değiştirip güncelle butonuna basarak güncelleyebiliyoruz.
            guncelle.Parameters.AddWithValue("@p1", txtAd.Text);            
            guncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", BirthDayPicker.Value);
            guncelle.Parameters.AddWithValue("@p4", JoinDayPicker.Value);
            guncelle.Parameters.AddWithValue("@p5", cmbDepartment.SelectedValue);
            guncelle.Parameters.AddWithValue("@p6", textBox1.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();    
            MessageBox.Show("Personel Güncellendi.");
            EslemeFonk();
        }
        
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//Uygulamamızı sağ üstte bulunan çarpıdan kapattığımızda arka planda çalışmasını önlemek amacı ile bu Even içine bu fonksiyonu çağırarak, uygulamamızın arka planda çalışmasını engelliyoruz.
        }
    }
}
