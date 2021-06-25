using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EhliyetRandevuFacade
{
    public class EhliyetRandevuFacade
    {
        private FotografRandevu _fotografRandevu;
        private NufusMudurluguRandevu _nufusMudurluguRandevu;
        private SaglikRaporuRandevu _saglikRaporuRandevu;
        
        public EhliyetRandevuFacade()
        {
            _fotografRandevu = new FotografRandevu();
            _nufusMudurluguRandevu = new NufusMudurluguRandevu();
            _saglikRaporuRandevu = new SaglikRaporuRandevu();
        }

        public void EhliyetRandevusuAl(Basvuran basvuran)
        {
            Console.WriteLine("Tüm randevularınız alındı!");
            Console.WriteLine("\nAd:"+basvuran.Ad+"\nSoyad:"+basvuran.SoyAd+"\nTC:"+basvuran.TC+"\nBilgilerine sahip kişinin randevu bilgileri aşağıdadır");
            Console.WriteLine("\nFotoğraf Randevunuz: ");
            _fotografRandevu.FotografRandevuAl();
            Console.WriteLine("\nNüfüs Müdürlüğü Randevunuz:");
            _nufusMudurluguRandevu.NufusRandevuAl();
            Console.WriteLine("\nSağlık Raporu randevunuz: ");
            _saglikRaporuRandevu.SaglikRandevuAl();
        }
    }
}