using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace sohpet.Pages
{
    public class sohbetModel : PageModel
    {
        private readonly ILogger<sohbetModel> _logger;
        private readonly ISingle _singleton;

        public sohbetModel(ILogger<sohbetModel> logger, ISingle singleton)
        {
            _logger = logger;
            _singleton = singleton;
        }

        public string sohbet { get; set; }
        public void OnGet()
        {
            sohbet = _singleton.mesajOku();
        }
    }
}
