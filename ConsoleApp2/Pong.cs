namespace ConsoleApp2
{
    public class Pong
    {
        public EventHandler PongEvent;

        public void AddPingFriend(Ping ping)
        {
            ping.PingEvent += PingReceivedEvent;
        }

        private void PingReceivedEvent(object? sender, EventArgs e)
        {
            Console.WriteLine("Ping received pong");
            Thread.Sleep(1000);
            PongEvent.Invoke(this, EventArgs.Empty);
        }
    }
}
