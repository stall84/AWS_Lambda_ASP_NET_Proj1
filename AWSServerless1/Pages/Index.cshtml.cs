using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AWSServerless1.Pages
{
    public class IndexModel : PageModel
    {
       public DayOfWeek DayOfWeek { get; set; }
        
        public List<string> CheckList { get; set; }

        public string[] arrGreets = { "Sup Bruh", "Hi Dude", "Hello", "Yo!", "Chillin", "What it is?", "SHEYA!!" };
        public IndexModel()
        {
            CheckList = new List<string>();
            CheckList.AddRange(arrGreets);
        }

        public void OnGet()
        {

            

        }
    }
}
