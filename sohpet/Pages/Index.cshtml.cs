using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sohpet.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ISingle _singleton;

        public IndexModel(ILogger<IndexModel> logger, ISingle singleton)
        {
            _logger = logger;
            _singleton = singleton;
        }
        public string isim { get; set; }
        public string mesaj { get; set; }
        public string sohbet { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {//mesaj ekle
            isim = Request.Form["isim"];
            mesaj = Request.Form["mesaj"]; //küfür, yasaklı kelime, emoji desteği yok
            string sonuc = isim + " (" + DateTime.Now.ToString("HH:mm") + ") " + mesaj;
            _singleton.mesajEkle(sonuc);
        }
    }
}
