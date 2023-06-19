namespace ObserverPattern;

class Program
{
    public static void Main(string[] args)
    {
        var WPU = new Youtube("WPU");
        var dody = new User("dody");
        var fahrul = new User("fahrul");
        var diana = new User("diana");

        dody.Subscribe(WPU);
        fahrul.Subscribe(WPU);

        WPU.AddNewVideo("tutorial javascript part1");

        Console.WriteLine("dody notif : {0}", dody.GetNotification());
        Console.WriteLine("fahrul notif : {0}", fahrul.GetNotification());
        Console.WriteLine("diana notif : {0}", diana.GetNotification());
    }
}
