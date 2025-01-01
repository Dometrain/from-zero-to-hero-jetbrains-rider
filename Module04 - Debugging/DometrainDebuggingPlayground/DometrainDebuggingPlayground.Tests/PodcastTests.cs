using System.Diagnostics;
using System.Net;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

namespace DometrainDebuggingPlayground.Tests;

public class PodcastTests
{
    [Fact]
    public async Task GetPodcastsTests()
    {
        var client = new WebApplicationFactory<Program>().CreateClient();
        var response = await client.GetAsync("/podcasts");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}