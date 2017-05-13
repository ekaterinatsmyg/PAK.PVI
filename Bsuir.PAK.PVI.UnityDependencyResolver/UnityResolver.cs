using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Dependencies;
using Microsoft.Practices.Unity;

namespace Bsuir.PAK.PVI.UnityDependencyResolver
{
    public class ScopeContainer : IDependencyScope
    {
        protected readonly IUnityContainer _container;

        public ScopeContainer(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }
            this._container = container;
        }

        public object GetService(Type serviceType)
        {

            if (!_container.IsRegistered(serviceType))
            {
                if (serviceType.IsAbstract || serviceType.IsInterface)
                {
                    return null;
                }
            }
            return _container.Resolve(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.IsRegistered(serviceType) ? _container.ResolveAll(serviceType) : new List<object>();
        }

        public void Dispose()
        {
            _container.Dispose();
        }
    }

    public class IoCContainer : ScopeContainer, IDependencyResolver
    {
        public IoCContainer(IUnityContainer container) : base(container)
        {
        }

        public IDependencyScope BeginScope()
        {
            var child = _container.CreateChildContainer();
            return new ScopeContainer(child);
        }
    }
}
