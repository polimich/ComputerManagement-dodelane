using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ComputerManagement.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public string NameSort { get; set; }
        public string IdSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IList<Computer> Computers { get; set; }

        public SelectList RoomList { get; set; }

        
        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            NameSort = sortOrder == "Name" ? "name_desc" : "Name";
            IdSort = sortOrder == "Id" ? "id_desc" : "Id";
            CurrentFilter = searchString;

            IQueryable<Computer> computerIQ = from s in _db.Computers
                                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                computerIQ = computerIQ.Where(s => s.Name.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "Name":
                    computerIQ = computerIQ.OrderBy(s => s.Name);
                    break;
                case "name_desc":
                    computerIQ = computerIQ.OrderByDescending(s => s.Name);
                    break;
                case "id_desc":
                    computerIQ = computerIQ.OrderByDescending(s => s.Id);
                    break;
                case "Id":
                    computerIQ = computerIQ.OrderBy(s => s.Id);
                    break;
                default:
                    computerIQ = computerIQ.OrderBy(s => s.Id);
                    break;
            }

            Computers = await computerIQ.AsNoTracking().ToListAsync();
        }
    }
}
