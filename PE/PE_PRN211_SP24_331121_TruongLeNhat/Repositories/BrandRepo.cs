using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BrandRepo
    {
        public List<Brand> GetBrands() =>
            new WatchDb2024Context().Brands.ToList();
    }
}
