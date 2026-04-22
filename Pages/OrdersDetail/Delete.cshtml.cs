using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TH_502045_2.Models;

namespace TH_502045_2.Pages.OrdersDetail
{
    public class DeleteModel : PageModel
    {
        private readonly TH_502045_2.Models.DBContext _context;

        public DeleteModel(TH_502045_2.Models.DBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OrderDetail OrderDetail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderdetail = await _context.OrdersDetail.FirstOrDefaultAsync(m => m.ID == id);

            if (orderdetail is not null)
            {
                OrderDetail = orderdetail;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderdetail = await _context.OrdersDetail.FindAsync(id);
            if (orderdetail != null)
            {
                OrderDetail = orderdetail;
                _context.OrdersDetail.Remove(OrderDetail);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
