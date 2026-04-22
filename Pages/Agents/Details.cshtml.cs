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
    public class DetailsModel : PageModel
    {
        private readonly TH_502045_2.Models.DBContext _context;

        public DetailsModel(TH_502045_2.Models.DBContext context)
        {
            _context = context;
        }

        public Agent Agent { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agent = await _context.Agents.FirstOrDefaultAsync(m => m.AgentID == id);

            if (agent is not null)
            {
                Agent = agent;

                return Page();
            }

            return NotFound();
        }
    }
}
