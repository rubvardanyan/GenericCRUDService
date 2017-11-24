using ExampleApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleApplication.Controllers
{
    public class BooksController : Controller
    {
        private ExAppDataContext _exAppDataContext;
        
        public BooksController(ExAppDataContext exAppDataContext)
        {
            _exAppDataContext = exAppDataContext;
            _exAppDataContext.Database.EnsureCreated();
        }
        
    }
}