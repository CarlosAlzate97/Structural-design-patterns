using Proxy;

public static class Client
{
    public static void Main()
    {
        Task user1Accesing = Task.Run(() => {
            IAccess registry = new RegistryProxy("USER_1");
            registry.Access();
            Thread.Sleep(1000);
        });
        user1Accesing.Wait();

        Task user2Accesing = Task.Run(() => {
            IAccess registry = new RegistryProxy("USER_2");
            registry.Access();
            Thread.Sleep(1000);
        });
        user2Accesing.Wait();
    }
}