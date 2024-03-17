using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class SanalDatabase
    {
        public static List<Kullanıcı> kullaniciadıListe = new List<Kullanıcı>();

        static SanalDatabase()
        {
            kullaniciadıListe.Add(new Kullanıcı()
            {
                id = 1,
                isim="zeynep",
                soyisim="anl",
                kullaniciadi ="zey.anl",
                sifre="1",
                aciklama="fgdh"
            });

            kullaniciadıListe.Add(new Kullanıcı()
            {
                id = 2,
                isim = "betül",
                soyisim = "snyz",
                kullaniciadi = "bet.snyz",
                sifre = "123",
                aciklama = "vkvmlcxç"
            });


        }
    }
}
