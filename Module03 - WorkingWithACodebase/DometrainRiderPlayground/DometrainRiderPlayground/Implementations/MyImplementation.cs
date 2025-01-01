using DometrainRiderPlayground.Interfaces;
using System.Text.Json;

namespace DometrainRiderPlayground.Implementations;

public class MyImplementation : IMyInterface
{
    public int MyPublicMethodCallCounter { get; set; }

    public void MyPublicMethod()
    {
        Console.WriteLine($"Hi! I'm public, and I've been called {MyPublicMethodCallCounter} times!");
        MyPublicMethodCallCounter++;
        MyPrivateMethod();
    }

    private void MyPrivateMethod()
    {
        Console.WriteLine("Shhh, I'm private!");

        var myList = new List<string>();

        foreach (var item in GetItems())
        {
            if (item.StartsWith("Foo"))
                myList.Add(item);
        }
    }

    private List<string>? GetItems() =>
        new List<string> { "Foo", "Bar" };
}
