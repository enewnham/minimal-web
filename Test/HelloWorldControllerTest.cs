using Xunit;
using Api.Controllers.HelloWorld;
using System.Net.Http;
using System.Threading.Tasks;

namespace test;

public class HelloWorldControllerTest : IClassFixture<ApiFixture>
{
    public HelloWorldControllerTest(ApiFixture apiFixture)
    {
        m_ApiFixture = apiFixture;
        m_Client = apiFixture.HttpClient;
    }

    [Fact]
    public async Task Get_ShouldReturn()
    {
        var response = await m_Client.GetAsync("/hello-world");

        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadAsAsync<HelloWorld>();

        Assert.Equal("World", result.Hello);
    }

    private readonly ApiFixture m_ApiFixture;
    private readonly HttpClient m_Client;
}