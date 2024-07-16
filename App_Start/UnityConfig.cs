using System.Web.Http;
using Unity;
using CdbCalculatorAPI.Services;
using Unity.AspNet.WebApi;

public static class UnityConfig
{
    public static IUnityContainer Container { get; private set; }

    public static void RegisterComponents()
    {
        var container = new UnityContainer();
        container.RegisterType<IInvestmentService, InvestmentService>();

        Container = container;

        GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
    }
}
