using ConsoleApp2;


Ping ping = new Ping();
Pong pong = new Pong();
ping.AddPongFriend(pong);
pong.AddPingFriend(ping);

ping.PingEvent.Invoke(null, EventArgs.Empty);



