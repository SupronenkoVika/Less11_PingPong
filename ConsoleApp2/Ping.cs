namespace ConsoleApp2
{
    public class Ping
    {
        public EventHandler PingEvent;

        public void AddPongFriend(Pong pong)
        {
            pong.PongEvent += PongReceivedEvent;
        }

        private void PongReceivedEvent(object? sender, EventArgs e)
        {
            Console.WriteLine("Pong received ping");
            Thread.Sleep(1000);
            PingEvent.Invoke(this, EventArgs.Empty);
        }
    }
}

