using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TH_502045_2.Models;

namespace TH_502045_2.Pages.Items
{
    public class DetailsModel : PageModel
    {
        private readonly TH_502045_2.Models.DBContext _context;

        public DetailsModel(TH_502045_2.Models.DBContext context)
        {
            _context = context;
        }

        public Item Item { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items.FirstOrDefaultAsync(m => m.ItemID == id);

            if (item is not null)
            {
                Item = item;

                return Page();
            }

            return NotFound();
        }
    }
}
