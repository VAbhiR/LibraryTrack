using LibraryCRUD.Data;
using LibraryCRUD.Models;
using LibraryCRUD.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryCRUD.Controllers
{
    public class LibrariesController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public LibrariesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddLibraryViewModel viewModel)
        {
            var Library = new Library
            {
                Title = viewModel.Title,
                Author = viewModel.Author,
                UserName = viewModel.UserName,
                Phone = viewModel.Phone,

            };
            await dbContext.libraries.AddAsync(Library);
            await dbContext.SaveChangesAsync();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var libraries = await dbContext.libraries.ToListAsync();
            return View(libraries);
        }
    }
}
