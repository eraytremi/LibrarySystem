using LibrarySystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Controllers
{
    public class GetListController : Controller
    {
        private readonly BookListDbContext _listDbContext;

        public GetListController(BookListDbContext listDbContext)
        {
            _listDbContext = listDbContext;
        }

     
            public async Task<IActionResult> GetList(string Search)
            {
                ViewData["Filter"] = Search;
                var book = from b in _listDbContext.bookList
                            select b;
                if (!String.IsNullOrEmpty(Search))
                {
                    book = book.Where(b => b.Name.Contains(Search) || b.Author.Contains(Search));
                }
                return View(book);
            }
        
    }
}
