using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;

namespace BethanysPieShop.Services
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _context;

        public PieRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Pie> GetAllPie()
        {
            return _context.Pies.OrderBy(p => p.Name);         
        }

        public Pie GetPieById(int pieid)
        {
            return _context.Pies.FirstOrDefault(p => p.Id == pieid);
        }
    }
}
