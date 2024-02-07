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
    public partial class SalonListe : Form
    {
        public SalonListe()
        {
            InitializeComponent();
        }
        VeriTabani veriTabani = new VeriTabani(); // Yeni database sınıfı oluşturulur ve tanımlanır.
        private void button1_Click(object sender, EventArgs e)
        {
            // Database sınıfından veri işlenir ve veriler tekrar alınır.
            veriTabani.Ekle_Oda(textBox1.Text);
            Al_Veri();
        }
      
        public void Degistir_Veritabani(Object veritabani) // Dışarıdan alınan database sınıfı burda oluşturulan database'e eşitlenir.
        {
            veriTabani = (VeriTabani)veritabani;
        }
        private void Al_Veri()
        {
            // Datagridview1'deki satırlar silinir ve database sınıfından veriler alınıp datagridview1'e satır olarak eklenir.
            dataGridView1.Rows.Clear();
            foreach (var veri in veriTabani.Al_Oda_List())
            {
                dataGridView1.Rows.Add(veri);
            }
        }

        private void Room_List_Load(object sender, EventArgs e)
        {
            // Datagridview1'e room_name sütunu eklenir ve veriler tekrar alınır.


            dataGridView1.Columns.Add("oda_adi", "Salon Adı");
            Al_Veri();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagridview1'den bir veri seçildiğinde textbox1 e yazar
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["oda_adi"].FormattedValue.ToString();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagridview1'den bir veri seçildiğinde textbox1 e yazar
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["oda_adi"].FormattedValue.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Database sınıfından istenilen veri silinir ve veriler tekrar alınır.
            veriTabani.Sil_Oda(textBox1.Text);
            Al_Veri();
        }

        private void SalonListe_Load(object sender, EventArgs e)
        {
            // Datagridview1'e room_name sütunu eklenir ve veriler tekrar alınır.


            dataGridView1.Columns.Add("oda_adi", "Salon Adı");
            Al_Veri();
        }
    }
}
