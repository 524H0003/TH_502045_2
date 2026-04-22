using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TH_502045_2.Models;

namespace TH_502045_2.Pages.Agents
{
    public class IndexModel : PageModel
    {
        private readonly TH_502045_2.Models.DBContext _context;

        public IndexModel(TH_502045_2.Models.DBContext context)
        {
            _context = context;
        }

        public IList<Agent> Agent { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Agent = await _context.Agents.ToListAsync();
        }
    }
}
