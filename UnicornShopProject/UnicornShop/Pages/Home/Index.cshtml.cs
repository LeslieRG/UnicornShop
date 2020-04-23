using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UnicornShop.DAL;
using UnicornShop.Models;

namespace UnicornShop
{
    public class IndexModel : PageModel
    {
        private readonly UnicornShop.DAL.UnicornShopContext _context;

        public IndexModel(UnicornShop.DAL.UnicornShopContext context)
        {
            _context = context;
        }

        public IList<Producto> Producto { get;set; }

        public async Task OnGetAsync()
        {
            Producto = await _context.Producto.ToListAsync();
        }
    }
}
