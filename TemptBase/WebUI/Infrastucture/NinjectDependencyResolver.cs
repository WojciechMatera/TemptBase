using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Moq;
using System.Web.Mvc;
using TemptBase.Domain.Abstract;
using TemptBase.Domain.Entities;

namespace TemptBase.WebUI.Infrastucture
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
            Mock<IParametrRepository> mock = new Mock<IParametrRepository>();
            mock.Setup(m => m.Parametry).Returns(new List<Parametr>
            {
                new Parametr { Name = "Cel" , Value = 1},
                new Parametr { Name = "Cel", Value = 5},
                new Parametr { Name = "Cel", Value = 15}
            });

            kernel.Bind<IParametrRepository>().ToConstant(mock.Object);
        }
    }
}