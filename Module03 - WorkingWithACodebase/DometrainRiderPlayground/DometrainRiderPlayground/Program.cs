using DometrainRiderPlayground.Handlers;

namespace DometrainRiderPlayground;

public class Program
{
    public static void Main()
    {
        var myFirstHandler = new MyFirstHandler();
        myFirstHandler.Execute();
    }
}
