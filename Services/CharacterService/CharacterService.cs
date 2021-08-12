using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.Models;

namespace First.Services.CharacterService
{
    public class CharacterService : ICharacterSerive
    {
        
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character{Name = "Shiva"}
        };
        
        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character?> GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c =>c.Id==id);
        }

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }
    }
}