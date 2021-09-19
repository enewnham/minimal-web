using System;
using System.Net.Http;

public class ApiFixture : IDisposable
{
    public ApiFixture()
    {
    }

    public void Dispose()
    {
        m_ApiFactory.Dispose();
    }

    public HttpClient HttpClient => m_ApiFactory.CreateClient();

    public IServiceProvider Services => m_ApiFactory.Services;

    private ApiFactory<Api.Startup> m_ApiFactory = new();
}