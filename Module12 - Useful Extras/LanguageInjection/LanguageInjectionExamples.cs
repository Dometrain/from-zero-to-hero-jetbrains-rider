using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace LanguageInjection;

internal class LanguageInjectionExamples
{
    public string? MyRegex1 { get; set; } = "\bD.*train\b";

    [StringSyntax(StringSyntaxAttribute.Regex)]
    public string? MyRegex2 { get; set; } = "\b(D.*train)\b";

    [RegexPattern]
    public string? MyRegex3 { get; set; } = "\bD.*train\b";

    [LanguageInjection(InjectedLanguage.HTML)]
    public string? MyHtml { get; set; } = "<div></div>";
}