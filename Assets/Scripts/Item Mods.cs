using UnityEngine;

[CreateAssetMenu(fileName = "New Mod", menuName = "Inventory/Mod")]
public class ItemMods : ScriptableObject
{
    public string modName;
    public ModType modType;
    public enum ModType
    {
        PoisonResistance,
        FireResistance,
        ColdResistance,
        LightningResistance,
        Armour,
        EvasionRating,
        BlockChance,
        AvoidCritical,
        MaxHP,
        IncreasedHP,
        Shield,
        Bleed,
        Poison,
        CriticalChance,
        CriticalDamage,
        FireDamage,
        IncreasedFire,
        IncreasedCold,
        IncreasedLightning,
        Lifesteal,
        LightningDamage,
        ColdDamage,
        PenetrateElementalResistance,
        PhysicalDamage,
        IncreasedPhysical,
        StunChance,
    }
    public int minValue;
    public int maxValue;

    public int GetRandomValue()
    {
        return Random.Range(minValue, maxValue);
    }

    public void ApplyMod(Player player, int value)
    {
        switch (modType)
        {
            case ModType.PoisonResistance:
                player.poisonResistance += value;
                break;
            case ModType.FireResistance:
                player.fireResistance += value;
                break;
            case ModType.ColdResistance:
                player.coldResistance += value;
                break;
            case ModType.LightningResistance:
                player.lightningResistance += value;
                break;
            case ModType.Armour:
                player.armour += value;
                break;
            case ModType.EvasionRating:
                player.evasionRating += value;
                break;
            case ModType.BlockChance:
                player.chanceToBlock += value;
                break;
            case ModType.AvoidCritical:
                player.criticalAvoidance += value;
                break;
            case ModType.MaxHP:
                player.maxHealth += value;
                break;
            case ModType.IncreasedHP:
                player.maxHealth *= (1 + (value/100)); // or player.currentHealth = (int)(player.currentHealth * (1 + value / 100.0f));
                break;
            case ModType.Shield:
                player.maxShield += value;
                break;
            case ModType.Bleed:
                player.chanceToBleed += value;
                break;
            case ModType.Poison:
                player.chanceToPoison += value;
                break;
            case ModType.CriticalChance:
                player.critChance += value;
                break;
            case ModType.CriticalDamage:
                player.criticalDamage += value;
                break;
            case ModType.FireDamage:
                player.fireDamage += value;
                break;
            case ModType.IncreasedFire:
                player.increasedFireDamage += value;
                break;
            case ModType.IncreasedCold:
                player.increasedColdDamage += value;
                break;
            case ModType.IncreasedLightning:
                player.increasedLightningDamage += value;
                break;
            case ModType.Lifesteal:
                player.lifesteal += value;
                break;
            case ModType.LightningDamage:
                player.lightningDamage += value;
                break;
            case ModType.ColdDamage:
                player.coldDamage += value;
                break;
            case ModType.PenetrateElementalResistance:
                player.elementalPenetration += value;
                break;
            case ModType.PhysicalDamage:
                player.physicalDamage += value;
                break;
            case ModType.IncreasedPhysical:
                player.increasedPhysicalDamage += value;
                break;
            case ModType.StunChance:
                player.stunChance += value;
                break;
            default:
                Debug.LogWarning("ModType not recognized: " + modType);
                break;
        }
    }
}
