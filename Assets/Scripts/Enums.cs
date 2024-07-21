using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
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
    public enum DamageType
    {
        Fire,
        Cold,
        Lightning,
        Physical,
        Poison,
        Mixed,
    }
}
