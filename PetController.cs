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

    [HttpPatch(nameof(UpdatePet))]
    public Pet UpdatePet([FromBody]UpdatePetRequestDto p)
    {
        return petService.UpdatePet(p);
    }

    [HttpDelete(nameof(DeletePet))]
    public Pet DeletePet(string petId)
    {
        return petService.DeletePet(petId);
    }

    [HttpGet(nameof(GetAllPets))]
    public List<Pet> GetAllPets()
    {
        return petService.GetAllPets();
    }
    
}