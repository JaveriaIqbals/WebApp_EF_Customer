using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_EF_Customer.Data;
using WebApp_EF_Customer.Model;

namespace WebApp_EF_Customer.Pages
{
    public class EditModel : PageModel
    {
        ShopDbContext _db;
        public EditModel(ShopDbContext db)
        {
            _db = db;
        }

        [BindProperty(SupportsGet = true)]
        public Customer Cust { get; set; }
        
        // This id will be received from URL...
        public void OnGet(int id)
        {
            Cust = _db.customers.Find(id);
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            // Update info for that Id
            _db.customers.Update(Cust);
            _db.SaveChanges();
            return RedirectToPage("/CustPages/Index");
        }
    }
}
