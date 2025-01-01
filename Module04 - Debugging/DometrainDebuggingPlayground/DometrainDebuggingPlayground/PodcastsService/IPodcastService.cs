namespace DometrainDebuggingPlayground.PodcastsService;

public interface IPodcastService
{
    Task<IEnumerable<Podcast>> GetPodcastsAsync();
    Task<IEnumerable<Podcast>> GetPodcastsByGenreAsync(string genre);
    IAsyncEnumerable<Podcast> GetPodcastsBySearchTermAsync(string searchTerm);
}