using PerformanceModule;

var scenario = Menu.Display();

switch (scenario)
{
    case ProfilingScenario.CpuDemo:
        Console.WriteLine("Calculating Fibonacci...");
        var fibCalculator = new FibonacciCalculator();
        var result = fibCalculator.Calculate(45); // Large number to simulate CPU usage
        Console.WriteLine($"Fibonacci(45): {result}");
        break;

    case ProfilingScenario.MemoryDemo:
        Console.WriteLine("Starting Memory Leak Demo...");
        var memoryDemo = new SimulatedMemoryLeak();
        memoryDemo.Start();
        break;
}

Console.WriteLine("Profiling Demo Complete. Press any key to exit...");
Console.ReadKey();