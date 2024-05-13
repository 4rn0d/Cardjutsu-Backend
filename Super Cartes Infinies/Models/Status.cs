namespace Super_Cartes_Infinies.Models;

public class Status
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Icon { get; set; }

    public const int POISONED_ID = 1;
    public const int STUNNED_ID = 2;
}