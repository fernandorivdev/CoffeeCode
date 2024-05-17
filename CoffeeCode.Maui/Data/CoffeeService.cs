
using CoffeeCode.Library.Data;
using System.Net.Http.Json;

namespace CoffeeCode.Maui.Data;

public class CoffeeService : ICoffeeService
{
    private readonly HttpClient _httpClient = new();
    public async Task<IEnumerable<Coffee>?> LoadCoffeesAsync()
    {
  
        var coffees = await _httpClient.GetFromJsonAsync<IEnumerable<Coffee>>(
            "https://api.sampleapis.com/coffee/iced");

        return coffees;
    }
}
