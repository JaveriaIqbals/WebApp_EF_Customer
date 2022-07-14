using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_EF_Customer.Data;
using WebApp_EF_Customer.Model;

namespace WebApp_EF_Customer.Pages.CustPages
{
    public class DeleteModel : PageModel
    {
        ShopDbContext _db;
        public DeleteModel(ShopDbContext db)
        {
            _db = db;
        }

        [BindProperty(SupportsGet = true)]
        public Customer Cust { get; set; }
        // This id will be used from URL Query string
        // Query string has id from route-id of Index page
        public void OnGet(int id)
        {
            Cust = _db.customers.Find(id);
        }

        public IActionResult OnPost()
        {
            //var CustToDelete = _db.customers.Find(Cust.Id);
            if (Cust.Id != null)
            {
               _db.customers.Remove(Cust);
               _db.SaveChanges();
                return RedirectToPage("/CustPages/Index");
            }
            return Page();
        }
    }
}
