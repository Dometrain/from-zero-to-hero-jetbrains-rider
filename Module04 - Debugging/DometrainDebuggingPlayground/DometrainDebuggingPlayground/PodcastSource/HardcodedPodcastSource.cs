namespace DometrainDebuggingPlayground.PodcastSource;

public class HardcodedPodcastSource : IPodcastSource
{
    public Task<IEnumerable<Podcast>> GetPodcastsAsync()
    {
        var podcasts = new List<Podcast>
        {
            new(
                "Unhandled Exception Podcast",
                "dotnet",
                "https://unhandledexceptionpodcast.com/"),
            new(
                "Keep Coding Podcast",
                "dotnet",
                "https://www.youtube.com/@keepcodingpodcast"),
            new(
                "Kubernetes Podcast",
                "Kubernetes",
                "https://kubernetespodcast.com/"),
        };

        return Task.FromResult<IEnumerable<Podcast>>(podcasts);
    }
}