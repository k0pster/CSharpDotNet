using Microsoft.AspNetCore.Mvc;
using books_mvc.Models;

namespace books_mvc.Controllers
{
    public class BooksController : Controller
    {
        // GET: BooksController
        public ActionResult Index()
        {
            var books = new Books();
            return View("allBooks", books);
        }

        public ActionResult FavoriteBook()
        {
            var books = new Books();
            return View(books);
        }
    }
}
