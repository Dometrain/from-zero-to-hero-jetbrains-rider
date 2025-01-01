using DometrainRiderPlayground.Implementations;

namespace DometrainRiderPlayground.Handlers;

public class MySecondHandler
{
    public void Execute()
    {
        var myImplementation = new MyImplementation();
        myImplementation.MyPublicMethod();
    }
}
