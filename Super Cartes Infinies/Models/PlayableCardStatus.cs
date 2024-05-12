namespace Super_Cartes_Infinies.Models;

public class PlayableCardStatus
{
    public int Id { get; set; }
    public int Value { get; set; }
    public virtual Status Status { get; set; }
}