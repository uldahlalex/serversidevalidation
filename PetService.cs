using System.ComponentModel.DataAnnotations;

namespace serversidevalidation;

public class PetService
{
    private readonly PetDatabase _db;
    

    public PetService(PetDatabase db)
    {
        Console.WriteLine("This has been instantiated (PetService)");
        _db = db;
    }

    public Pet CreatePet(CreatePetRequestDto pet)
    {
        Validator.ValidateObject(pet, 
            new ValidationContext(pet), 
            true);
        var petEntity = new Pet(
            age: pet.Age,
            name: pet.Name, 
            createdAt: DateTime.UtcNow,
            id: Guid.NewGuid().ToString());
      _db.AllPets.Add(petEntity);
      return petEntity;
    }

    public Pet UpdatePet(UpdatePetRequestDto pet)
    {
        Validator.ValidateObject(pet, 
            new ValidationContext(pet), 
            true);
        var existingPet = _db.AllPets.First(p => p.Id == pet.Id);
        existingPet.Age = pet.Age;
        existingPet.Name = pet.Name;
        return existingPet;
    }

    public Pet DeletePet(string petId)
    {
        var existingPet = _db.AllPets.First(p => p.Id == petId);
        _db.AllPets.Remove(existingPet);
        return existingPet;
    }

    public List<Pet> GetAllPets()
    {
        return _db.AllPets;
    }
}