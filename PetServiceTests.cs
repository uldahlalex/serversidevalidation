using System.ComponentModel.DataAnnotations;
using Xunit;

namespace serversidevalidation;

public class PetServiceTests
{
    [Fact]
    public void CreatePet_ShouldFail_WhenThereAreValidationErrors()
    {
        var db = new PetDatabase();
            var petService = new PetService(db);
            var createDto = new CreatePetRequestDto()
            {
                Age = -1,
                Name = ""
            };
            Assert.ThrowsAny<Exception>(() => petService.CreatePet(createDto));
    }
}