using Car_Agency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Agency.Domain.Abstract
{
   public interface CarsRepository
    {
        IEnumerable<Car> cars { get; }
       
      
    }
}
