namespace PerformanceModule;

public class FibonacciCalculator
{
    public int Calculate(int n)
    {
        // Inefficient recursive implementation
        if (n <= 1) return n;
        return Calculate(n - 1) + Calculate(n - 2);
    }
}