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
    public partial class SatisListe : Form
    {
        VeriTabani veriTabani = new VeriTabani();
        public SatisListe()
        {
            InitializeComponent();
        }

        public void Degistir_Veritabani(Object veritabani) // Dışarıdan alınan database sınıfı burda oluşturulan database'e eşitlenir.
        {
            veriTabani = (VeriTabani)veritabani;

        }

        private void SatisListe_Load(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.Rows.Clear(); // Datagridview1'deki satırlar silinir;

                foreach (var veri in veriTabani.Al_Bilet_List()) // Alınan biletler datagridview1'e işlenir.
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    int columnIndex = 0;

                    foreach (var veri1 in veri)
                    {
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = veri1;
                        columnIndex++;
                    }
                    rowIndex++;
                }


            }
            catch {  MessageBox.Show("Satış Verileri Alınırken Hata Oluştu"); }

        }
    }
}
