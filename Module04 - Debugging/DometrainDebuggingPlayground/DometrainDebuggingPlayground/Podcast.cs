using System.Diagnostics;

namespace DometrainDebuggingPlayground;

[DebuggerDisplay("{Title} - {Genre}")]
public record Podcast(string Title, string Genre, string Url);