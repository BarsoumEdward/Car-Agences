using Car_Agency.Domain.Abstract;
using Car_Agency.Domain.Concrete;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Car_Agency.Infrastructure
{
    public class NinjectDependencyResolver:IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelparam)
        {
            kernel = kernelparam;
            AddBindings();
        }
        private void AddBindings()
        {

            kernel.Bind<CarsRepository>().To<EFCarsRepository>();

        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}