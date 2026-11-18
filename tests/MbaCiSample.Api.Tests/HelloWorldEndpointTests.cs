using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace MbaCiSample.Api.Tests;

public class HelloWorldEndpointTests(WebApplicationFactory<Program> factory)
    : IClassFixture<WebApplicationFactory<Program>>
{
    [Fact]
    public async Task Get_HelloWorld_ReturnsMessage()
    {
        using var client = factory.CreateClient();

        using var response = await client.GetAsync("/hello-world");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal("""{"message":"Hello World!"}""", await response.Content.ReadAsStringAsync());
    }
}
