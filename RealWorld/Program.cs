using RealWorld.Components;
using RealWorld.Decorators;

internal class Program
{
    private static void Main(string[] args)
    {
        Book book = new Book("Worley", "Inside ASP.NET", 10);
        book.Display();

        Video video = new Video("Spielberg", "Jaws", 15);
        video.Display();

        Console.WriteLine("------------------------");

        Console.WriteLine("***Making video borrowable:");
        Borrowable borrowvideo = new Borrowable(video);
        borrowvideo.BorrowItem("Customer #1");
        borrowvideo.BorrowItem("Customer #2");
        borrowvideo.BorrowItem("Customer #3");
        borrowvideo.BorrowItem("Customer #4");
        borrowvideo.Display();

        Console.WriteLine("****** video RetunItem:");
        borrowvideo.RetunItem("Customer #1");
        borrowvideo.RetunItem("Customer #2");

        borrowvideo.Display();

        Console.ReadKey();
    }
}