using ConfigReader;
using System;
using Unity;


public class Program
{
	public  static void Main(string[] args)
    {
        IUnityContainer unityContainer = new UnityContainer();
        unityContainer.RegisterSingleton<DBConfigReader>();
        unityContainer.RegisterSingleton<RegistryConfigReader>();

        Client client = new Client(unityContainer.Resolve<DBConfigReader>());
        client.DoWork();  
    }
}
