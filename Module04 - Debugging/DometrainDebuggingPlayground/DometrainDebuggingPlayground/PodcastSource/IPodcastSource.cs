namespace DometrainDebuggingPlayground.PodcastSource;

public interface IPodcastSource
{
    Task<IEnumerable<Podcast>> GetPodcastsAsync();
}