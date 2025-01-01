namespace AiAssistantDemo;

// Implement a class that solves FizzBuzz
public class FizzBuzzSolverGitHubCopilot
{
    // Implement a method that solves FizzBuzz
    public string Solve(int number)
    {
        // If the number is divisible by 3 and 5, return "FizzBuzz"
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }
        // If the number is divisible by 3, return "Fizz"
        else if (number % 3 == 0)
        {
            return "Fizz";
        }
        // If the number is divisible by 5, return "Buzz"
        else if (number % 5 == 0)
        {
            return "Buzz";
        }
        // Otherwise, return the number as a string
        else
        {
            return number.ToString();
        }
    }
}