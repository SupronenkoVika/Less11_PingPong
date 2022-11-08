using ConsoleApp2;


class Program
{
    delegate void Del();
    static void Main(string[] args)
    {
        Ping ping = new Ping();
        Pong pong = new Pong();

        Del pi = ping.PingMeth;
        Del po = pong.PongMeth;

        while (true)
        {
            pi();
            po();
            Thread.Sleep(2000);
        }
    }
}

