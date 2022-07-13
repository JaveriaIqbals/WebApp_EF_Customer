using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_EF_Customer.Data;
using WebApp_EF_Customer.Model;

namespace WebApp_EF_Customer.Pages.CustPages
{
    public class IndexModel : PageModel
    {
        public ShopDbContext _db;

        // Dep Injection Constructor
        public IndexModel(ShopDbContext db)
        {
            _db = db;
        }
        
        // [BindProperty]
        public IEnumerable<Customer> Customers { get; set; } 
        public void OnGet()
        {
            Customers = _db.customers;//.ToList();
        }
    }
}
