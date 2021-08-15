using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Pages.Models;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public int Width { get; set; }
        [BindProperty]
        public int Ratio { get; set; }
        [BindProperty]
        public int Rim { get; set; }
        

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public WheelModel Wheel { get; set; }  //cria uma instancia 'Wheel' do tipo WheelModel
        
        public void OnGet()
        {
           
        }

        

        public void OnPost()
        {
            
        }
    }
}
