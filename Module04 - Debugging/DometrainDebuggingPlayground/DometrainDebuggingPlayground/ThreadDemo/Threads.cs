namespace DometrainDebuggingPlayground.ThreadDemo;

public static class Threads
{
    private static MyThreadInfo MyThreadInfo { get; } = new();

    public static void Execute()
    {
        // Create some threads
        new Thread(DoWork1) { Name = "My Thread 1" }.Start();
        new Thread(DoWork2) { Name = "My Thread 2" }.Start();
        new Thread(DoWork1) { Name = "My Thread 3" }.Start();

        // Create a thread via Task.Run
        Task.Run(DoWork3);

        // Do an async/await operation
        CreateLongRunningTask();
    }

    private static async Task CreateLongRunningTask() =>
        await Task.Delay(TimeSpan.FromMinutes(10));

    private static void DoWork1()
    {
        while (true)
        {
            Console.WriteLine($"Doing some work {DateTimeOffset.Now}");
            MyThreadInfo.Message = "Set by DoWork1";
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }

    private static void DoWork2()
    {
        while (true)
        {
            Console.WriteLine($"Doing some work {DateTimeOffset.Now}");
            MyThreadInfo.Message = "Set by DoWork2";
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }

    private static void DoWork3()
    {
        while (true)
        {
            Console.WriteLine($"Doing some work {DateTimeOffset.Now}");
            MyThreadInfo.Message = "Set by DoWork3";
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }
}