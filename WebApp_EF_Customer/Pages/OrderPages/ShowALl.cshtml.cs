using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_EF_Customer.Data;
using WebApp_EF_Customer.Model;

namespace WebApp_EF_Customer.Pages.OrderPages
{
    public class ShowALlModel : PageModel
    {
        ShopDbContext _db;
        public ShowALlModel(ShopDbContext db)
        {
            _db = db;
        }
        public List<Order> orders { get; set; }
        public void OnGet()
        {
          orders  = _db.orders.ToList();
        }
    }
}
