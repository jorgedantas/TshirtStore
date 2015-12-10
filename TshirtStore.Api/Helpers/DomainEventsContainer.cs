using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Http.Dependencies;
using IContainer = TshirtStore.SharedKernel.IContainer;

namespace TshirtStore.Api.Helpers
{
    public class DomainEventsContainer : IContainer
    {
        private IDependencyResolver _resolver;

        public DomainEventsContainer(IDependencyResolver resolver)
        {
            _resolver = resolver;
        }

        public object GetService(Type serviceType)
        {
            return _resolver.GetService(serviceType);
        }

        public T GetService<T>()
        {
            return (T)_resolver.GetService(typeof(T));
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _resolver.GetServices(serviceType);
        }

        public IEnumerable<T> GetServices<T>()
        {
            return (IEnumerable<T>)_resolver.GetServices(typeof(T));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Add(IComponent component)
        {
            throw new NotImplementedException();
        }

        public void Add(IComponent component, string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(IComponent component)
        {
            throw new NotImplementedException();
        }

        public ComponentCollection Components { get; }
    }
}