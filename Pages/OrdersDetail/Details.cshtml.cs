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
    public class DetailsModel : PageModel
    {
        private readonly TH_502045_2.Models.DBContext _context;

        public DetailsModel(TH_502045_2.Models.DBContext context)
        {
            _context = context;
        }

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
    }
}
