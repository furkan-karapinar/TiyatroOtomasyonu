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
    public partial class OyunListe : Form
    {
        VeriTabani veriTabani = new VeriTabani(); // Yeni database sınıfı oluşturulur ve tanımlanır.
        public OyunListe()
        {
            InitializeComponent();
        }
        public void Degistir_Veritabani(Object veritabani) // Dışarıdan alınan database sınıfı burda oluşturulan database'e eşitlenir.
        {
            veriTabani = (VeriTabani)veritabani;
        }
        private void Al_Veri() // Database sınıfından veri almak için oluşturulmuş method
        {
            // DataGridView1'in satırları temizlenir ve database sınıfından yeni veriler işlenir.
            dataGridView1.Rows.Clear();
            foreach (var veri in veriTabani.Al_Oyun_Liste())
            {
                dataGridView1.Rows.Add(veri);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView1'den bir veri seçildiğinde textbox1 e yazar
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["oyun_adi"].FormattedValue.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView1'den bir veri seçildiğinde textbox1 e yazar
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["oyun_adi"].FormattedValue.ToString();

            }
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            // Database sınıfına veri işlenir ve veriler tekrar alınır.
            veriTabani.Ekle_Oyun(textBox1.Text);

            Al_Veri();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Database sınıfından istenilen veri silinir ve veriler tekrar alınır.
            veriTabani.Sil_Oyun(textBox1.Text);
            Al_Veri();
        }

        private void OyunListe_Load(object sender, EventArgs e)
        {
            // gosteri Listesi yüklendiğinde datagridview1'e gosteri_name sütununu ekler ve satırlarına database sınıfından veriler işlenir.

            dataGridView1.Columns.Add("oyun_adi", "Oyun Adı");
            Al_Veri();
        }
    }
}
