using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace serversidevalidation;

[ApiController]
public class PetController(PetService petService) : ControllerBase
{
    
    [HttpPost(nameof(CreatePet))]
    public Pet CreatePet([FromBody]CreatePetRequestDto p)
    {
        var result = petService.CreatePet(p);
        return result;
    }
    
    
}

public record CreatePetRequestDto
{
    [MinLength(3)]
    public string Name { get; set; }
    [Range(0,15)]
    public int Age { get; set; }
}