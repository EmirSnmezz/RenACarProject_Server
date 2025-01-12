using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System.Reflection;

namespace Business.DependencyResolver.AutoFac
{
    public class AutoFacBusinessModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<CarDal>().As<ICarDal>().SingleInstance();

            var assembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly)
                .AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new Castle.DynamicProxy.ProxyGenerationOptions()
                {
                    Selector = new MethodInterceptorSelector()
                }).SingleInstance();
        }
    }
}
