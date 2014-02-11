using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Dependencies;

namespace WebApi.Config
{
    public class WebApiDependencyResolver : IDependencyResolver

    {
        private readonly List<object> _services;

        public WebApiDependencyResolver()
        {
            _services = new List<object>();
        }

        public void Dispose()
        {
            _services.ForEach(s =>
            {
                var disposable = s as IDisposable;
                if (disposable != null)
                {
                    disposable.Dispose();
                }
            });

            _services.Clear();
        }

        public object GetService(Type serviceType)
        {
            if (!typeof(ApiController).IsAssignableFrom(serviceType))
            {
                return null;
            }

            var controller = Activator.CreateInstance(serviceType);
            _services.Add(controller);

            return controller;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new List<object>();
        }

        public IDependencyScope BeginScope()
        {
            return new WebApiDependencyScope();
        }
    }

    public class WebApiDependencyScope : IDependencyScope
    {
        private readonly List<object> _services;

        public WebApiDependencyScope()
        {
            _services = new List<object>();
        }

        public void Dispose()
        {
            _services.ForEach(s =>
                              {
                                  var disposable = s as IDisposable;
                                  if (disposable != null)
                                  {
                                      disposable.Dispose();
                                  }
                              });

            _services.Clear();
        }

        public object GetService(Type serviceType)
        {
            if (!typeof (ApiController).IsAssignableFrom(serviceType))
            {
                return null;
            }

            var controller = Activator.CreateInstance(serviceType);
            _services.Add(controller);

            return controller;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new List<object>();
        }
    }
}
