using Microsoft.AspNetCore.Mvc;

namespace serversidevalidation;

public class PetController : ControllerBase
{
    private readonly PetService _petService;

    public PetController(PetService p)
    {
        _petService = p;
    }
    
    public Pet CreatePet([FromBody] Pet p)
    {
        var result = _petService.CreatePet(p);
        return result;
    }
}