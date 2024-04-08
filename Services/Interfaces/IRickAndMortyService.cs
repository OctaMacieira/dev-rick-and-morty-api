using dev_rick_and_morty_api.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace dev_rick_and_morty_api.Services.Interfaces;

public interface IRickAndMortyService
{
    public Task<List<Character>> GetCharacter();
}