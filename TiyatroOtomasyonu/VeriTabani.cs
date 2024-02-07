using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiyatroOtomasyonu
{
    internal class VeriTabani
    {

        // Program çalıştığı sürece varolacak ve database olarak kullanacağımız listeler.

        List<string> oyun_list = new List<string>(); // Gösteri listesi
        List<string> seans_list = new List<string>(); // Seanslar Listesi
        List<List<string>> bilet_list = new List<List<string>>(); // Alınan Biletler Listesi
        List<int> ucret_list = new List<int>() { 60, 40, 30 }; // Ücret Ayarları Listesi (Yetişkin , Öğrenci , Çocuk)
        List<string> room_list = new List<string>(); // Salon Listesi



        public void Ekle_Oyun(string oyun_adi) // Gösteri listesine yeni veri eklenir.
        {
            oyun_list.Add(oyun_adi);
        }

        public void Sil_Oyun(string oyun_adi) // Gösteri listesindeki istenilen veriyi siler.
        {
            oyun_list.Remove(oyun_adi);
        }

        public List<string> Al_Oyun_Liste() // Gösteri listesini çağırılan yere geri döndürür.
        {
            return oyun_list;
        }

        public void Ekle_Seans(string zaman) // Seans saatleri listesine yeni veri eklenir.
        {
            seans_list.Add(zaman);
        }

        public void Sil_Seans(string zaman) // Seans saatleri listesindeki istenilen veriyi siler.
        {
            seans_list.Remove(zaman);
        }

        public List<string> Al_Seans_List() // Seans saatleri listesini çağırılan yere geri döndürür.
        {
            return seans_list;
        }

        public void Ekle_Bilet(string tam_adi, string oyun_adi, string oda_no, string bilet_tarihi, string zaman, string koltuk_no, string ucret)
        {
            // Alınan biletler listesine yeni veriler ekler.
            bilet_list.Add(new List<string> { tam_adi, oyun_adi, oda_no, bilet_tarihi, zaman, koltuk_no, ucret });
        }

        public void Sil_Bilet(string tam_adi, string oyun_adi, string oda_no, string bilet_tarihi, string zaman, string koltuk_no, string ucret)
        {
            /* 
            
            Alınan biletler listesindeki istenilen verileri siler.
            Çağırılan yerden alınan verilerle bir liste oluşturulur ve bu liste alınan bilet listesinde aranır bulunursa silinir.

            */

            List<string> silinecek_veri = new List<string> { tam_adi, oyun_adi, oda_no, bilet_tarihi, zaman, koltuk_no, ucret };


            int index = bilet_list.FindIndex(item => Enumerable.SequenceEqual(item, silinecek_veri));

            if (index != -1)
            {
                // Belirtilen indeksteki öğeyi kaldırma
                bilet_list.RemoveAt(index);
            }
        }

        public int Kontrol_Koltuk( int koltuk_no)
        {
            // Burası istenilen koltuğun dolu ya da boş olduğunu kontrol eder.
            // Alınan biletler listesindeki veriler alınır ve karşılaştırılır.
            // İstenilen koltuğun dolu olup olmadığı kullanıcıya belirtilir.
            // Hata durumunda kullanıcıya hata oluştuğu bildirilir ve varsayılan olarak koltuğun boş olduğu belirtilir.
            List<string> koltuk_numaralari = bilet_list.Select(item => item[5]).ToList();
            int v = 0;
            try
            {

                foreach (var s in koltuk_numaralari)
                {
                    v = Convert.ToInt32(s);
                }

                if (koltuk_no == v)
                {
                    return 1;
                }
                else
                    return 0;

            }
            catch { MessageBox.Show("Veri Alımı Hatası"); return 0; }
        }

        public void Al_Koltuk_Bilgi(String tarih, String oda_adi, String zaman,AnaEkran ana_ekran)
        {
            // Burası Ana ekrandaki koltuk göstergesi içindir.
            // Alınan biletler listesindeki dolu koltuk bilgileri alınır ve oluşturulan yeni koltuk göstergesine işlenir.
            // Ardından istenilen yere koltuk göstergesi objesi olarak geri döndürür.
            // Hata durumunda tüm koltukların boş olduğunu gösteren varsayılan koltuk göstergesi döndürülür.
            // Ve kullanıcıya hata oluştuğu konusunda bilgi verilir.

            List<string> chairNumbers = bilet_list
            .Where(item => item[3] == tarih && item[2] == oda_adi && item[4] == zaman)
            .Select(item => item[5]).ToList();
            ana_ekran.tumunu_bos_isaretle();
            try
            {
                foreach (string s in chairNumbers)
                {
                    ana_ekran.dolu_isaretle(Int32.Parse(s));
                }
                
            }
            catch { MessageBox.Show("Veri Alımı Hatası");  }

        }

        public List<List<string>> Al_Bilet_List() // Alınan biletler listesini çağırılan yere geri döndürür.
        {
            return bilet_list;
        }

        public void Ekle_Oda(string oda_no) // Salon Listesine yeni veri eklenir.
        {
            room_list.Add(oda_no);
        }

        public void Sil_Oda(string oda_no) // Salon Listesinden istenilen veri silinir.
        {
            room_list.Remove(oda_no);
        }

        public List<string> Al_Oda_List() // Salon Listesi çağırılan yere geri döndürülür.
        {
            return room_list;
        }


        public int Al_Ucret_List(int type) // İstenilen müşteri tipinin ücretini çağırılan yere geri döndürür. (Yetiskin = 0 , Öğrenci = 1 , Çocuk = 2)
        {
            return ucret_list[type];
        }

    }
}
