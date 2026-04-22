using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TH_502045_2.Models;

namespace TH_502045_2.Pages.OrdersDetail
{
    public class CreateModel : PageModel
    {
        private readonly TH_502045_2.Models.DBContext _context;

        public CreateModel(TH_502045_2.Models.DBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ItemID"] = new SelectList(_context.Items, "ItemID", "ItemID");
        ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderID");
            return Page();
        }

        [BindProperty]
        public OrderDetail OrderDetail { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OrdersDetail.Add(OrderDetail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
