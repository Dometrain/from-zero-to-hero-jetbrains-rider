using DometrainRiderPlayground.Implementations;

namespace DometrainRiderPlayground.Handlers;

public class MyFirstHandler
{
    public void Execute()
    {
        var myImplementation = new MyImplementation();
        myImplementation.MyPublicMethod();
    }
}
