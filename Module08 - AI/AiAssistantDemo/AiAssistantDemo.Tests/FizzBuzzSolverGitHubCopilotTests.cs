namespace AiAssistantDemo.Tests;

public class FizzBuzzSolverAiAssistantTests
{
    [Fact]
    public void SolveFizzBuzz_GeneratesCorrectOutputForFizz()
    {
        // Arrange
        var solver = new FizzBuzzSolverAiAssistant();
        var expectedOutput = "1\n2\nFizz\n4\nBuzz\n".Replace("\n", Environment.NewLine);

        // Act
        var result = CaptureConsoleOutput(() => solver.SolveFizzBuzz(5));

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void SolveFizzBuzz_GeneratesCorrectOutputForFizzBuzz()
    {
        // Arrange
        var solver = new FizzBuzzSolverAiAssistant();
        var expectedOutput =
            "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n".Replace("\n", Environment.NewLine);

        // Act
        var result = CaptureConsoleOutput(() => solver.SolveFizzBuzz(15));

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void SolveFizzBuzz_ShouldOutputNumberWhenNotFizzOrBuzz()
    {
        // Arrange
        var solver = new FizzBuzzSolverAiAssistant();
        var expectedOutput = "1".Replace("\n", Environment.NewLine);

        // Act
        var result = CaptureConsoleOutput(() => solver.SolveFizzBuzz(1));

        // Assert
        Assert.Equal(expectedOutput + Environment.NewLine, result);
    }

    [Fact]
    public void SolveFizzBuzz_ShouldHandleEdgeCaseOfZero()
    {
        // Arrange
        var solver = new FizzBuzzSolverAiAssistant();

        // Act
        var result = CaptureConsoleOutput(() => solver.SolveFizzBuzz(0));

        // Assert
        Assert.Equal(string.Empty, result); // No output expected for 0
    }

    [Fact]
    public void SolveFizzBuzz_ShouldProduceFizzForMultiplesOfThree()
    {
        // Arrange
        var solver = new FizzBuzzSolverAiAssistant();
        var expectedOutput = "1\n2\nFizz\n".Replace("\n", Environment.NewLine);

        // Act
        var result = CaptureConsoleOutput(() => solver.SolveFizzBuzz(3));

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    // Helper method to capture console output for testing
    private string CaptureConsoleOutput(Action action)
    {
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            action.Invoke();
            return sw.ToString();
        }
    }
}