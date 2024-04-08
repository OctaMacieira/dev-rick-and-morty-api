using dev_rick_and_morty_api.Models;
using dev_rick_and_morty_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace dev_rick_and_morty_api.Controllers;

[ApiController]
[Route("[controller]")]
public class RickAndMortyQueryController : ControllerBase
{
    private readonly ILogger<RickAndMortyQueryController> _logger;
    public RickAndMortyService Service;

    public RickAndMortyQueryController(ILogger<RickAndMortyQueryController> logger
                                        ,RickAndMortyService service)
    {
        _logger = logger;
        Service = service;
    }

    [HttpGet(Name = "GetCharacterInfo")]
    public async Task<List<Character>> Get()
    {
        var result = await Service.GetCharacter();

        return result;
    }
}
