
using CoffeeCode.Library.Data;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CoffeeCode.BlazorServer.Data;

public class CoffeeService : ICoffeeService
{
    private readonly IHttpClientFactory _factory;

    public CoffeeService(IHttpClientFactory factory)
    {
        _factory = factory;
    }
    public async Task<IEnumerable<Coffee>?> LoadCoffeesAsync()
    {
        using var httpClient = _factory.CreateClient();

        var coffees = await httpClient.GetFromJsonAsync<IEnumerable<Coffee>>(
            "https://api.sampleapis.com/coffee/iced");

        return coffees;
    }
}
