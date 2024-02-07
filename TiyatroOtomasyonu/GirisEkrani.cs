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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            
            Button1'e tıklandığında;

            Kullanıcı adı ve şifre doğru ise 'Giriş Başarılı!' mesajı gösterilir.
            Mesajdan çıkıldıktan sonra yeni bir main form objesi oluşturulur ve login formu kendini gizler.
            Daha sonra oluşturulan yeni main form showdialog yöntemiyle çağırılır ki devamındaki kodların çalışması engellensin.
            Oluşturulan main formundan çıkıldığında programın tamamen kapanması için this.close() kodu çalıştırılır.
            Eğer Kullanıcı Adı ve Şifre doğru değilse veya herhangi biri doğru değilse 'Hatalı Giriş!' mesajını gösterir.
             
            */


            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "password")
                {
                    MessageBox.Show("Giriş Başarılı!");
                    AnaEkran main = new AnaEkran();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş!");
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!");
            }
        }
    }
}

