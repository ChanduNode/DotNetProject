using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using First.Models;
using First.Services.CharacterService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace First.Controllers
{
    [ApiController]
     [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterSerive _characterservice;
        public CharacterController(ICharacterSerive characterservice)
        {
            _characterservice = characterservice;
            
        }
        // private static List<Character> characters = new List<Character>
        // {
        //     new Character(),
        //     new Character{Name = "Shiva"}
        // };

    
        
[HttpGet]
 [Route("GetAll")]
        public async Task<ActionResult<List<Character>>> Get()
        {
            return Ok(await _characterservice.GetAllCharacters());
        }
         [HttpGet("{id}")]
         // [Route("OneChar")]
         public async Task<ActionResult<Character>> GetSingle(int id)
         {
             return Ok(await _characterservice.GetCharacterById(id));
         }
[HttpPost]
         public async Task<ActionResult<List<Character>>> AddCharacter(Character character)
         {
            
             return Ok(await _characterservice.AddCharacter(character));
         }

    }
}