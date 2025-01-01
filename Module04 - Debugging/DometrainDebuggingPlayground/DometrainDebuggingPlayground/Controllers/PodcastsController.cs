using DometrainDebuggingPlayground.PodcastsService;
using Microsoft.AspNetCore.Mvc;

namespace DometrainDebuggingPlayground.Controllers;

[ApiController]
[Route("[controller]")]
public class PodcastsController(
    IPodcastService podcastService
) : ControllerBase
{
    [HttpGet, Route("bygenre")]
    public async Task<IActionResult> GetByGenre([FromQuery] string genre) =>
        Ok(await podcastService.GetPodcastsByGenreAsync(genre));

    [HttpGet, Route("bysearchterm")]
    public Task<IActionResult> GetBySearchTerm([FromQuery] string searchTerm) =>
        Task.FromResult<IActionResult>(Ok(podcastService.GetPodcastsBySearchTermAsync(searchTerm)));
}