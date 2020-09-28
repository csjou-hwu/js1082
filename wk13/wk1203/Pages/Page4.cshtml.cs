using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace wk1203.Pages
{
    public class Page4Model : PageModel
    {
        private readonly ILogger<Page4Model> _logger;

        public Page4Model(ILogger<Page4Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
