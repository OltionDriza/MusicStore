using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Ninject;
using MusicStore.WebUI.Models;
using System.Configuration;
using MusicStore.WebUI.Infrastructure.Abstract;
using MusicStore.WebUI.Infrastructure.Concrete;

namespace   MusicStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
           

            kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }
    }
}