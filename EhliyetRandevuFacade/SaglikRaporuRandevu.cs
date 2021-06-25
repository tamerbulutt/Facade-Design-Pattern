using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EhliyetRandevuFacade
{
    public class SaglikRaporuRandevu
    {
        Basvuran basvuran = new Basvuran();
        List<string> saglikRandevuList = new List<string>(); //Sağlık kuruluşu randevularının bulunduğu liste
        public void SaglikRandevuAl()
        {
            foreach (string saglikRandevu in saglikRandevuList)
            {
                Console.WriteLine(saglikRandevu);//Tüm randevuları sıralıyoruz.
            }
            //Kullanıcı hangi randevuyu seçiceğine karar veriyor alttaki tarihi seçtiğini var sayıyoruz.
            basvuran.SaglikRandevuTarihi = new DateTime(2020, 06, 16, 10, 30, 00);
            Console.WriteLine("Saglik raporu randevusu "+basvuran.SaglikRandevuTarihi+ " tarihine alındı");
        }
    }
}
