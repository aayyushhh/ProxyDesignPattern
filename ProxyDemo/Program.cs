using ProxyDemo;

internal class Program
{
    static void Main(string[] args)
    {
        var secureNestProxy = new SecureNestProxy(new RealNest());

        secureNestProxy.Access("Stegosaurus");
        secureNestProxy.Access("TRex");
    }
}