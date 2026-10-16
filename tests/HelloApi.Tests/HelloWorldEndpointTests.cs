using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace HelloApi.Tests;

public class HelloWorldEndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public HelloWorldEndpointTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetHelloWorld_ReturnsOkWithGreeting()
    {
        var response = await _client.GetAsync("/helloworld");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal("Hello World!", await response.Content.ReadAsStringAsync());
    }
}
