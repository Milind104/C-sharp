using RealEstateApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Services
{
    public interface IRealStatePropertyServices
    {
        List<RealStateProperty> GetRealStateProperties();
        List<Category> GetCategories();
    }
}
