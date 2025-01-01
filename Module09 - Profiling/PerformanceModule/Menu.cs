using Spectre.Console;

namespace PerformanceModule;

internal static class Menu
{
    public static ProfilingScenario Display()
    {
        var prompt = new SelectionPrompt<(ProfilingScenario Scenario, string Description)>()
            .Title("Pick a profiling scenario")
            .AddChoices(
                (ProfilingScenario.CpuDemo, "Demonstrate CPU profiling"),
                (ProfilingScenario.MemoryDemo, "Demonstrate Memory profiling")
            );

        prompt.Converter = x => x.Item2;

        var choice = AnsiConsole.Prompt<(ProfilingScenario Scenario, string Description)>(prompt);

        return choice.Scenario;
    }
}