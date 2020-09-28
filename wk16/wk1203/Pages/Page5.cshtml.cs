using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace wk1203.Pages
{
    public class Page5Model : PageModel
    {
        private readonly ILogger<Page5Model> _logger;

        public Page5Model(ILogger<Page5Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
