using Microsoft.AspNetCore.Mvc;
using  Asp_._Net.Models;
using System.Collections.Generic;
using System.Linq;


namespace Asp_._Net.Controllers
{
    
       [ApiController]
       [Route("api/[controller]")]
       public class CharacterController: ControllerBase

    {

        private static List<Characters> characters = new List<Characters>     {
                new Characters(),
                new Characters     { id = 1,  name = "Faruque"  , hitPoits = 800   },
                new Characters     { name = "Josuel"     }

         };
         private static Characters cavaleiro = new Characters();

         [HttpGet("getAll")]
        public IActionResult get() { 

            return Ok(characters);
           }


         [HttpGet("get/{id}")]
        public IActionResult getSingle(int id) { 
                
                return Ok(characters.FirstOrDefault ( f  => f.id  == id));

         }
        

        
        
         [HttpPost("save")]
         public IActionResult addCharacter( Characters chars)  { 
                    characters.Add(chars);
                    return   Ok(200);
          }
           
        
    }
}