using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace wk1203.Pages
{
    public class Page3Model : PageModel
    {
        private readonly ILogger<Page3Model> _logger;

        public Page3Model(ILogger<Page3Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
