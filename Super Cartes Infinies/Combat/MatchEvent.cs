using System.Text.Json.Serialization;

namespace Super_Cartes_Infinies.Combat
{
    [JsonDerivedType(typeof(DrawCardEvent), typeDiscriminator: "DrawCard")]
    [JsonDerivedType(typeof(EndMatchEvent), typeDiscriminator: "EndMatch")]
    [JsonDerivedType(typeof(GainManaEvent), typeDiscriminator: "GainMana")]
    [JsonDerivedType(typeof(PlayCardEvent), typeDiscriminator: "PlayCard")]
    [JsonDerivedType(typeof(CombatEvent), typeDiscriminator: "Combat")]
    [JsonDerivedType(typeof(CardActivationEvent), typeDiscriminator: "CardActivation")]
    [JsonDerivedType(typeof(CardDamageEvent), typeDiscriminator: "CardDamage")]
    [JsonDerivedType(typeof(CardDeathEvent), typeDiscriminator: "CardDeath")]
    [JsonDerivedType(typeof(FirstStrikeEvent), typeDiscriminator: "FirstStrike")]
    [JsonDerivedType(typeof(HealEvent), typeDiscriminator: "Heal")]
    [JsonDerivedType(typeof(ThiefEvent), typeDiscriminator: "Thief")]
    [JsonDerivedType(typeof(PlayerDamageEvent), typeDiscriminator: "PlayerDamage")]
    [JsonDerivedType(typeof(PlayerDeathEvent), typeDiscriminator: "PlayerDeath")]
    [JsonDerivedType(typeof(ThornsEvent), typeDiscriminator: "Thorns")]
    [JsonDerivedType(typeof(PlayerEndTurnEvent), typeDiscriminator: "PlayerEndTurn")]
    [JsonDerivedType(typeof(PlayerStartTurnEvent), typeDiscriminator: "PlayerStartTurn")]
    [JsonDerivedType(typeof(StartMatchEvent), typeDiscriminator: "StartMatch")]
    [JsonDerivedType(typeof(SurrenderEvent), typeDiscriminator: "Surrender")]
    [JsonDerivedType(typeof(BoostAttackEvent), typeDiscriminator: "BoostAttack")]
    [JsonDerivedType(typeof(ChaosEvent), typeDiscriminator: "Chaos")]
    [JsonDerivedType(typeof(EarthquakeEvent), typeDiscriminator: "Earthquake")]
    [JsonDerivedType(typeof(LightningStrikeEvent), typeDiscriminator: "LightningStrike")]
    [JsonDerivedType(typeof(PoisonEvent), typeDiscriminator: "Poison")]
    [JsonDerivedType(typeof(RandomPainEvent), typeDiscriminator: "RandomPain")]
    [JsonDerivedType(typeof(ResurrectEvent), typeDiscriminator: "Resurrect")]
    [JsonDerivedType(typeof(StunEvent), typeDiscriminator: "Stun")]

    public abstract class MatchEvent
    {
        public MatchEvent()
        {
        }

        public List<MatchEvent>? Events { get; set; }
    }
}
