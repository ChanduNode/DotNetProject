using System.Collections.Generic;
using System.Threading.Tasks;
using First.Models;

namespace First.Services.CharacterService
{
    public interface ICharacterSerive
    {
       Task<List<Character>>  GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}