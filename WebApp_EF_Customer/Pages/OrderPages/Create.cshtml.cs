using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_EF_Customer.Data;
using WebApp_EF_Customer.Model;

namespace WebApp_EF_Customer.Pages.OrderPages
{
    public class CreateModel : PageModel
    {
        ShopDbContext _db;
        public CreateModel(ShopDbContext db)
        {
            _db = db;
        }

        [BindProperty(SupportsGet = true)]
        public Order order { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _db.orders.Add(order);
            _db.SaveChanges();
            return RedirectToPage("/CustPages/Index");   
        }
    }
}
