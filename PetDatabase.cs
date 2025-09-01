namespace serversidevalidation;

public class PetDatabase
{
    public PetDatabase()
    {
        Console.WriteLine("This has been instantiated");
    }
    public List<Pet> AllPets { get; set; } = new List<Pet>();
}