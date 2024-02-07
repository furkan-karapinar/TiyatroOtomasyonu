using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiyatroOtomasyonu
{
    public partial class AnaEkran : Form
    {

        VeriTabani veritabani = new VeriTabani(); // Yeni database sınıfı oluşturulur ve tanımlanır.
        public int yetiskin_ucret = 0;
        public int ogrenci_ucret = 0; // Yetişkin , öğrenci ve çocuk ücretlerinin tutulacağı değişkenler
        public int cocuk_ucret = 0;
        int secilen_ucret; // Seçilen ücreti tutacak değişken
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            verileri_al(); // Formdaki girdilere database sınıfındaki ilgili bilgileri işler
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void dolu_isaretle(int koltuk_no)
        {
            Image img = TiyatroOtomasyonu.Properties.Resources.dolu_koltuk;
            koltuk_isaretle(koltuk_no,img);
        }

        public void bos_isaretle(int koltuk_no)
        {
            Image img = TiyatroOtomasyonu.Properties.Resources.bos_koltuk;
            koltuk_isaretle(koltuk_no, img);
        }

        public void tumunu_bos_isaretle()
        {
            Image img = TiyatroOtomasyonu.Properties.Resources.bos_koltuk;
            for (int i = 1; i <= 64; i++)
            {
                koltuk_isaretle(i, img);
            } 
        }


        private void koltuk_isaretle(int koltuk_no,Image img)
        {
            try
            {
                switch (koltuk_no)
                {
                    case 1:
                        pictureBox1.Image = img;
                        break;
                    case 2:
                        pictureBox2.Image = img;
                        break;
                    case 3:
                        pictureBox3.Image = img;
                        break;
                    case 4:
                        pictureBox4.Image = img;
                        break;
                    case 5:
                        pictureBox5.Image = img;
                        break;
                    case 6:
                        pictureBox6.Image = img;
                        break;
                    case 7:
                        pictureBox7.Image = img;
                        break;
                    case 8:
                        pictureBox8.Image = img;
                        break;


                    case 9:
                        pictureBox9.Image = img;
                        break;
                    case 10:
                        pictureBox10.Image = img;
                        break;
                    case 11:
                        pictureBox11.Image = img;
                        break;
                    case 12:
                        pictureBox12.Image = img;
                        break;
                    case 13:
                        pictureBox13.Image = img;
                        break;
                    case 14:
                        pictureBox14.Image = img;
                        break;
                    case 15:
                        pictureBox15.Image = img;
                        break;
                    case 16:
                        pictureBox16.Image = img;
                        break;


                    case 17:
                        pictureBox17.Image = img;
                        break;
                    case 18:
                        pictureBox18.Image = img;
                        break;
                    case 19:
                        pictureBox19.Image = img;
                        break;
                    case 20:
                        pictureBox20.Image = img;
                        break;
                    case 21:
                        pictureBox21.Image = img;
                        break;
                    case 22:
                        pictureBox22.Image = img;
                        break;
                    case 23:
                        pictureBox23.Image = img;
                        break;
                    case 24:
                        pictureBox24.Image = img;
                        break;


                    case 25:
                        pictureBox25.Image = img;
                        break;
                    case 26:
                        pictureBox26.Image = img;
                        break;
                    case 27:
                        pictureBox27.Image = img;
                        break;
                    case 28:
                        pictureBox28.Image = img;
                        break;
                    case 29:
                        pictureBox29.Image = img;
                        break;
                    case 30:
                        pictureBox30.Image = img;
                        break;
                    case 31:
                        pictureBox31.Image = img;
                        break;
                    case 32:
                        pictureBox32.Image = img;
                        break;


                    case 33:
                        pictureBox33.Image = img;
                        break;
                    case 34:
                        pictureBox34.Image = img;
                        break;
                    case 35:
                        pictureBox35.Image = img;
                        break;
                    case 36:
                        pictureBox36.Image = img;
                        break;
                    case 37:
                        pictureBox37.Image = img;
                        break;
                    case 38:
                        pictureBox38.Image = img;
                        break;
                    case 39:
                        pictureBox39.Image = img;
                        break;
                    case 40:
                        pictureBox40.Image = img;
                        break;


                    case 41:
                        pictureBox41.Image = img;
                        break;
                    case 42:
                        pictureBox42.Image = img;
                        break;
                    case 43:
                        pictureBox43.Image = img;
                        break;
                    case 44:
                        pictureBox44.Image = img;
                        break;
                    case 45:
                        pictureBox45.Image = img;
                        break;
                    case 46:
                        pictureBox46.Image = img;
                        break;
                    case 47:
                        pictureBox47.Image = img;
                        break;
                    case 48:
                        pictureBox48.Image = img;
                        break;


                    case 49:
                        pictureBox49.Image = img;
                        break;
                    case 50:
                        pictureBox50.Image = img;
                        break;
                    case 51:
                        pictureBox51.Image = img;
                        break;
                    case 52:
                        pictureBox52.Image = img;
                        break;
                    case 53:
                        pictureBox53.Image = img;
                        break;
                    case 54:
                        pictureBox54.Image = img;
                        break;
                    case 55:
                        pictureBox55.Image = img;
                        break;
                    case 56:
                        pictureBox56.Image = img;
                        break;


                    case 57:
                        pictureBox57.Image = img;
                        break;
                    case 58:
                        pictureBox58.Image = img;
                        break;
                    case 59:
                        pictureBox59.Image = img;
                        break;
                    case 60:
                        pictureBox60.Image = img;
                        break;
                    case 61:
                        pictureBox61.Image = img;
                        break;
                    case 62:
                        pictureBox62.Image = img;
                        break;
                    case 63:
                        pictureBox63.Image = img;
                        break;
                    case 64:
                        pictureBox64.Image = img;
                        break;
                }
            }
            catch { MessageBox.Show("Koltuk Verisi Alınırken Hata Oluştu"); }

        }


        private void verileri_al()
        {
            // Try içindekiler yapılır. Hata durumunda belirtir.
            try
            {
                // Ana ekrandaki girdilere seçenekler girilir. (Gösteri listesi , Salon listesi, Seans listesi)

                foreach (var oyunlar in veritabani.Al_Oyun_Liste())
                {
                    comboBox1.Items.Add(oyunlar);
                }

                foreach (var oda in veritabani.Al_Oda_List())
                {
                    comboBox2.Items.Add(oda);
                }

                foreach (var saat in veritabani.Al_Seans_List())
                {
                    comboBox3.Items.Add(saat);
                }




                // Database sınıfından ücret bilgisini alır ve gerekli değişkenlere kaydeder.
                yetiskin_ucret = veritabani.Al_Ucret_List(0);
                ogrenci_ucret = veritabani.Al_Ucret_List(1);
                cocuk_ucret = veritabani.Al_Ucret_List(2);

                // Panel1'deki kontroller silinir ve ana ekrandaki gerekli bilgiler ile boş/dolu koltuk durumunu belirten
                // chair_view usercontrolünü panel1'e ekler.
              
                veritabani.Al_Koltuk_Bilgi(dateTimePicker1.Text, comboBox2.Text, comboBox3.Text,this);
            }
            catch { MessageBox.Show("Veri Alımı Hatası"); }
        }




        private void ucret()
        {
            try
            {
                // Ana ekrandaki koltuk göstergesi bilgisini yeniler.
                
                veritabani.Al_Koltuk_Bilgi(dateTimePicker1.Text, comboBox2.Text, comboBox3.Text,this);

                // Ana ekrandaki girdilere göre bilet ücretini belirler ve kullanıcıya gösterir.
                if (comboBox1.Text.Length != 0 & comboBox2.Text.Length != 0 & comboBox3.Text.Length != 0)
                {
                    if (radioButton1.Checked)
                    {
                        // Yetişkin ücreti
                        label9.Text = yetiskin_ucret + " TL";
                        secilen_ucret = yetiskin_ucret;
                    }
                    else if (radioButton2.Checked)
                    {
                        // Öğrenci ücreti
                        label9.Text = ogrenci_ucret + " TL";
                        secilen_ucret = ogrenci_ucret;
                    }
                    else if (radioButton3.Checked)
                    {
                        // Çocuk ücreti
                        label9.Text = cocuk_ucret + " TL";
                        secilen_ucret = cocuk_ucret;
                    }

                }
            }
            catch { }


        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ucret();  // Ana ekrandaki koltuk göstergesi bilgisini yeniler ve gerekli girdiler girildiğinde ücreti belirler ve gösterir.
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucret(); // Ana ekrandaki koltuk göstergesi bilgisini yeniler ve gerekli girdiler girildiğinde ücreti belirler ve gösterir.
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucret(); // Ana ekrandaki koltuk göstergesi bilgisini yeniler ve gerekli girdiler girildiğinde ücreti belirler ve gösterir.
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ucret(); // Ana ekrandaki koltuk göstergesi bilgisini yeniler ve gerekli girdiler girildiğinde ücreti belirler ve gösterir.
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ucret(); // Ana ekrandaki koltuk göstergesi bilgisini yeniler ve gerekli girdiler girildiğinde ücreti belirler ve gösterir.
        }


        private void ana_ekrani_temizle()
        {
            // Ana ekrandaki girdiler temizlenir.
            comboBox1.Text = string.Empty;
            comboBox1.Items.Clear();
            comboBox2.Text = string.Empty;
            comboBox2.Items.Clear();
            comboBox3.Text = string.Empty;
            comboBox3.Items.Clear();
            numericUpDown1.Value = 1;
            textBox1.Text = string.Empty;
            radioButton1.Checked = true;
            ucret();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Ana ekrandaki gerekli girdiler girildiğinde ve kaydedilmek istendiğinde sırasıyla aşağıdaki olaylar meydana gelir;
            // Eğer bilet satışı ise ilk önce istenilen koltuk dolu mu bakılır. Dolu ise kullanıcıya bildirilir.
            // Eğer bilet satışında istenilen koltuk dolu değilse kayıt tamamlanır.
            // Eğer bilet iptali ise gerekli bilgiler girilmiş ise bileti iptal eder ve dolu koltuğu boş gösterir.
            // Ardından ana ekranı günceller.
            // Hata oluşursa da kullanıcıya bildirilir.

            try
            {
                // Bilet satışı ise
                if (radioButton4.Checked)
                {
                    // Koltuk kontrolü
                    if (veritabani.Kontrol_Koltuk(Convert.ToInt32(numericUpDown1.Value)) != 0)
                    {
                        // Dolu ise
                        MessageBox.Show("Koltuk Zaten Alınmış");
                    }
                    else
                    {
                        // Dolu değilse kayıt oluşturulur

                        veritabani.Ekle_Bilet(textBox1.Text, comboBox1.Text, comboBox2.Text, dateTimePicker1.Text, comboBox3.Text, Convert.ToString(numericUpDown1.Value), secilen_ucret.ToString());

                    }

                }
                // Bilet iptali ise gerekli bilgiler doğrultusunda kaydı siler
                else if (radioButton5.Checked)
                {
                    veritabani.Sil_Bilet(textBox1.Text, comboBox1.Text, comboBox2.Text, dateTimePicker1.Text, comboBox3.Text, Convert.ToString(numericUpDown1.Value), secilen_ucret.ToString());

                }




                ana_ekrani_temizle();    // Ana ekrandaki girdileri temizler.

                verileri_al();    // Ana ekrandaki girdilere database sınıfındaki ilgili bilgileri işler


            }
            catch { MessageBox.Show("Kayıt Kaydedilirken Hata Oluştu."); }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ucret(); // Ana ekrandaki koltuk göstergesi bilgisini yeniler ve gerekli girdiler girildiğinde ücreti belirler ve gösterir.
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ana_ekrani_temizle(); // Ana ekrandaki girdiler temizlenir.
            verileri_al(); // Ana ekrandaki girdilere database sınıfındaki ilgili bilgileri işler
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ucret(); // Ana ekrandaki koltuk göstergesi bilgisini yeniler ve gerekli girdiler girildiğinde ücreti belirler ve gösterir.
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ucret(); // Ana ekrandaki koltuk göstergesi bilgisini yeniler ve gerekli girdiler girildiğinde ücreti belirler ve gösterir.
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ucret(); // Ana ekrandaki koltuk göstergesi bilgisini yeniler ve gerekli girdiler girildiğinde ücreti belirler ve gösterir.
        }




        private void button1_Click(object sender, EventArgs e)
        {
 SalonListe salon = new SalonListe();
            salon.Degistir_Veritabani(veritabani);
            salon.ShowDialog();
            ana_ekrani_temizle(); // Ana ekrandaki girdiler temizlenir.
            verileri_al(); // Ana ekrandaki girdilere database sınıfındaki ilgili bilgileri işler
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeansListe seans = new SeansListe();
            seans.Degistir_Veritabani(veritabani);
            seans.ShowDialog();
            ana_ekrani_temizle(); // Ana ekrandaki girdiler temizlenir.
            verileri_al(); // Ana ekrandaki girdilere database sınıfındaki ilgili bilgileri işler
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OyunListe oyun = new OyunListe();
            oyun.Degistir_Veritabani(veritabani);
            oyun.ShowDialog();
            ana_ekrani_temizle(); // Ana ekrandaki girdiler temizlenir.
            verileri_al(); // Ana ekrandaki girdilere database sınıfındaki ilgili bilgileri işler
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SatisListe satis = new SatisListe();
            satis.Degistir_Veritabani(veritabani);
            satis.ShowDialog();
            ana_ekrani_temizle(); // Ana ekrandaki girdiler temizlenir.
            verileri_al(); // Ana ekrandaki girdilere database sınıfındaki ilgili bilgileri işler
        }
    }
}