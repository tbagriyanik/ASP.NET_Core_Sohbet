using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sohpet.Pages
{
    public class tekil : ISingle
    {
        string tumMesajlar = "";

        public void mesajEkle(string gelen)
        {
            tumMesajlar = tumMesajlar + gelen + "\n";
        }
        public string mesajOku()
        {
            return tumMesajlar;
        }
    }
}
