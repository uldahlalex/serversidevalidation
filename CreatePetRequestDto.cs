using System.ComponentModel.DataAnnotations;

namespace serversidevalidation;

public record CreatePetRequestDto
{
    [MinLength(3)]
    public string Name { get; set; }
    [Range(0,15)]
    public int Age { get; set; }
}