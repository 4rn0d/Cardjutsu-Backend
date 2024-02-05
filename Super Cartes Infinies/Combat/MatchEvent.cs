using System.Text.Json.Serialization;

namespace Super_Cartes_Infinies.Combat
{
    [JsonDerivedType(typeof(DrawCardEvent), typeDiscriminator: "DrawCard")]
    [JsonDerivedType(typeof(EndMatchEvent), typeDiscriminator: "EndMatch")]
    [JsonDerivedType(typeof(GainManaEvent), typeDiscriminator: "GainMana")]
    [JsonDerivedType(typeof(PlayerEndTurnEvent), typeDiscriminator: "PlayerEndTurn")]
    [JsonDerivedType(typeof(PlayerStartTurnEvent), typeDiscriminator: "PlayerStartTurn")]
    [JsonDerivedType(typeof(StartMatchEvent), typeDiscriminator: "StartMatch")]
    [JsonDerivedType(typeof(SurrenderEvent), typeDiscriminator: "Surrender")]
    public abstract class MatchEvent
    {
        public MatchEvent()
        {
        }

        public List<MatchEvent>? Events { get; set; }
    }
}
