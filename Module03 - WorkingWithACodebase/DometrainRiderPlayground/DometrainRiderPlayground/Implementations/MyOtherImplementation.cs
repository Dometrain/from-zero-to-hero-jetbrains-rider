using DometrainRiderPlayground.Interfaces;

namespace DometrainRiderPlayground.Implementations;

public class MyOtherImplementation : IMyInterface
{
    public int MyPublicMethodCallCounter { get; set; }

    public void MyPublicMethod()
    {
        Console.WriteLine($"Hi! I'm a different implementation, and I've been called {MyPublicMethodCallCounter} times!");
        MyPublicMethodCallCounter++;
    }
}
