using BSL.v58.Core;
namespace BSL.v58;

public static class Program
{
    public static void Main(string[] args)
    {
        new LaserTcpCentralGateway(9339).Start();

        for (;;) ;
    }
}