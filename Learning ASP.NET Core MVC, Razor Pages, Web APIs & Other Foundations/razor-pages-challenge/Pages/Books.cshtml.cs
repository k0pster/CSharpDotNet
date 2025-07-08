using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_page_challange.Pages
{
    public class BooksModel : PageModel
    {

        public string[] RecommededBooks = ["Fashionable C#", "Bits of Binary", "Var output"];
        public void OnGet()
        {
        }
    }
}
