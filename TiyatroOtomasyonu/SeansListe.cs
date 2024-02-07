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
    public partial class SeansListe : Form
    {
        public SeansListe()
        {
            InitializeComponent();
        }
        VeriTabani veriTabani = new VeriTabani(); // Yeni database sınıfı oluşturulur ve tanımlanır.
        public void Degistir_Veritabani(Object veritabani) // Dışarıdan alınan database sınıfı burda oluşturulan database'e eşitlenir.
        {
            veriTabani = (VeriTabani)veritabani;
        }
        private void Al_Veri()
        {
            // Datagridview1 satırları silinir ve database sınıfından veriler alınıp datagridview1'e işlenir.
            dataGridView1.Rows.Clear();
            foreach (var veri in veriTabani.Al_Seans_List())
            {
                dataGridView1.Rows.Add(veri);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagridview1'den bir veri seçildiğinde label4 e yazar
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                label3.Text = dataGridView1.Rows[e.RowIndex].Cells["zaman"].FormattedValue.ToString();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagridview1'den bir veri seçildiğinde label4 e yazar
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                label3.Text = dataGridView1.Rows[e.RowIndex].Cells["zaman"].FormattedValue.ToString();

            }
        }

        private void seans_frm_Load(object sender, EventArgs e)
        {
            // Datagridview1'e time adına sütun ekler ve database sınıfından verileri alır.

            dataGridView1.Columns.Add("zaman", "Seans Saati");
            Al_Veri();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayılar, nokta ve kontrol tuşları izin verilsin
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Girişi engelle
            }

            // Birden fazla nokta girişini engelle
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Birden fazla nokta girişini engelle
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
 // VeriTabani sınıfındaki seans listesine veri işlenir ve veriler tekrar alınır.
            if (textBox1.Text == String.Empty || textBox1.Text == "") { MessageBox.Show("Geçersiz Saat Dilimi"); }
            else
            {
                String time = Convert.ToString(textBox1.Text);
                veriTabani.Ekle_Seans(time);
                Al_Veri();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // VeriTabani sınıfından istenilen veri silinir ve veriler tekrar alınır.
            veriTabani.Sil_Seans(label3.Text);
            Al_Veri();
        }
    }
}
