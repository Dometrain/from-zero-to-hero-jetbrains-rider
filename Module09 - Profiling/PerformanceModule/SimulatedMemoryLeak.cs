namespace PerformanceModule;

public class SimulatedMemoryLeak
{
    private readonly List<byte[]> _accidentalReferences = [];
    private const int AllocationSize = 10 * 1024 * 1024; // 10 MB

    public void Start()
    {
        var iteration = 0;

        while (true)
        {
            iteration++;

            // Allocation some memory for something
            var bytes = new byte[AllocationSize];

            // Some code here that uses the memory (not required for this demo)

            if (iteration % 3 == 0)
                // Sometimes, a reference is accidentally kept hold of (simulating a memory leak)
                _accidentalReferences.Add(bytes);

            // Slow down the loop for better graph visualization
            Thread.Sleep(1000);
        }

        // ReSharper disable once FunctionNeverReturns
    }
}