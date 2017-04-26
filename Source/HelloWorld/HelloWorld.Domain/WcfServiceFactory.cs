using System;
using System.ServiceModel;
using Microsoft.Practices.Unity;
using Unity.Wcf;
using Microsoft.Practices.Unity.Configuration;

namespace HelloWorld.Domain
{
    public static class IoCContainerManager
    {
        static IoCContainerManager()
        {
            InitContainer();
        }

        private static void InitContainer()
        {
            if (GetContainer != null) return;

            GetContainer = new UnityContainer();
            GetContainer.LoadConfiguration();
        }

        public static IUnityContainer GetContainer { get; private set; }

        public static T Resolve<T>()
        {
            InitContainer();

            return GetContainer.Resolve<T>();
        }
    }
    public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return new UnityServiceHost(IoCContainerManager.GetContainer, serviceType, baseAddresses);
        }

        protected override void ConfigureContainer(IUnityContainer container)
        {
            return;
        }
    }    
}