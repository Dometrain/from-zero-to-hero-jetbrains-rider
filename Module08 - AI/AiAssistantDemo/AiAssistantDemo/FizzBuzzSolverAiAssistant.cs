namespace AiAssistantDemo;

public class FizzBuzzSolverAiAssistant
{
    public void SolveFizzBuzz(int n)
    {
        for (var i = 1; i <= n; i++)
        {
            var output = string.Empty;

            if (i % 3 == 0)
            {
                output += "Fizz";
            }

            if (i % 5 == 0)
            {
                output += "Buzz";
            }

            if (string.IsNullOrEmpty(output))
            {
                output = i.ToString();
            }

            Console.WriteLine(output);
        }
    }
}