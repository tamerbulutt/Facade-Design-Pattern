using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EhliyetRandevuFacade
{
    public class NufusMudurluguRandevu
    {
        Basvuran basvuran = new Basvuran();
        List<string> NufusRandevuList = new List<string>(); //Nüfus müdürlüğü randevularının bulunduğu liste
        public void NufusRandevuAl()
        {
            foreach (string nufusRandevu in NufusRandevuList)
            {
                Console.WriteLine(nufusRandevu);//Tüm randevuları sıralıyoruz.
            }
            //Kullanıcı hangi randevuyu seçiceğine karar veriyor alttaki tarihi seçtiğini var sayıyoruz.
            basvuran.NufusRandevuTarihi = new DateTime(2020, 06, 17, 09, 30, 00);
            Console.WriteLine("Nüfus randevusu "+ basvuran.NufusRandevuTarihi+" tarihine alındı!");
        }
    }
}
