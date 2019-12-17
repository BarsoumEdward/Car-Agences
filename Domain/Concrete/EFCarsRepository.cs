using Car_Agency.Domain.Abstract;
using Car_Agency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Agency.Domain.Concrete
{
    public class EFCarsRepository:CarsRepository
    {
       
       public IEnumerable<Car> cars
        {
            get
            {
                EFDbContext context = new EFDbContext();
                return context.cars;
            }

          
        }
    }
}