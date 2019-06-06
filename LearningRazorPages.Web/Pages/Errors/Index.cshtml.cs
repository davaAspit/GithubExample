using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearningRazorPages.Web.Pages.Errors
{
    public class IndexModel : PageModel
    {
        public string ErrorMessage { get; set; }

        public void OnGet(int id)
        {
            switch (id)
            {
                case 404:
                    ErrorMessage = "Siden blev ikke fundet...";
                    break;
                default:
                    ErrorMessage = "Der opstod en ukendt fejl...";
                    break;
            }
        }
    }
}