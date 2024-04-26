using Repositories;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    
    public class BrandSer
    {
        private BrandRepo brandRepo = new();
        public List<Brand> GetBrands () => 
            brandRepo.GetBrands ();

    }
}
