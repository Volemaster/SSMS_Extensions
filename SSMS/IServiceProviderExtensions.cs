using System;

namespace SSMS
{
    public static class IServiceProviderExtensions
    {
        public static T GetService<T>(this IServiceProvider serviceProvider) => (T)serviceProvider.GetService(typeof(T));
        public static T GetService<T>(this IServiceProvider serviceProvider, Type serviceType) => (T)serviceProvider.GetService(serviceType);
        public static T GetService<T,RequestedServiceType>(this IServiceProvider serviceProvider) => (T)serviceProvider.GetService(typeof(RequestedServiceType));
    }
}
