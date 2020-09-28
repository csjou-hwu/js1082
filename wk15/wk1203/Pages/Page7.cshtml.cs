using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace wk1203.Pages
{
    public class Page7Model : PageModel
    {
        private readonly ILogger<Page7Model> _logger;

        public Page7Model(ILogger<Page7Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
