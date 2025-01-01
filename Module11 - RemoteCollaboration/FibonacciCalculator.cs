namespace PerformanceModule;

public class FibonacciCalculator
{
    public int Calculate(int n)
    {
        if (n == 0) return 0;

        var prev = new[] { 0, 1 };
        var current = 1;

        for (var i = 2; i <= n; i++)
        {
            current = prev[0] + prev[1];
            prev[0] = prev[1];
            prev[1] = current;
        }

        return current;
    }
}