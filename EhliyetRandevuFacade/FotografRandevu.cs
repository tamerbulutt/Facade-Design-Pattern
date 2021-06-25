using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EhliyetRandevuFacade
{
    public class FotografRandevu
    {
        Basvuran basvuran = new Basvuran();
        List<string> fotoRandevuList = new List<string>(); //Fotoğraf randevularının bulunduğu liste
        public void FotografRandevuAl()
        {
            foreach (string fotoRandevu in fotoRandevuList)
            {
                Console.WriteLine(fotoRandevu);//Tüm randevuları sıralıyoruz.
            }
            //Kullanıcı hangi randevuyu seçiceğine karar veriyor alttaki tarihi seçtiğini var sayıyoruz.
            basvuran.FotografRandevuTarihi = new DateTime(2020, 06, 17, 12, 30, 00);
            Console.WriteLine("Fotoğraf randevusu "+ basvuran.FotografRandevuTarihi+" tarihine alındı");
        }
    }
}
