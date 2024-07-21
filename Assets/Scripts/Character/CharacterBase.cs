using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour, IDamageable
{
    public int currentHealth;
    public float maxHealth;
    public int level;
    public int baseAttackDamage;
    public string characterName;

    // Defensive stats
    public int maxShield;
    public int currentShield;
    public int evasionRating;
    public int armour;
    public int fireResistance;
    public int coldResistance;
    public int lightningResistance;
    public int poisonResistance;
    public int critChance;
    public int criticalDamage;
    public int fireDamage;
    public int coldDamage;
    public int lightningDamage;
    public int physicalDamage;
    public int increasedPhysicalDamage;
    public int increasedFireDamage;
    public int increasedColdDamage;
    public int increasedLightningDamage;
    public int chanceToPoison;
    public int chanceToBleed;
    public int elementalPenetration;
    public int stunChance;
    public int chanceToBlock;
    public int lifesteal;

    [System.Serializable]
    public struct GenericDamage
    {
        public int physicalDamage;
        public int fireDamage;
        public int coldDamage;
        public int lightningDamage;
        public int poisonDamage;
    }

    protected virtual void OnEnable()
    {
    }

    public void TakeDamage(GenericDamage damage)
    {
        float totalDamage = CalculateTotalDamage(damage);
        currentHealth -= (int)totalDamage;
        Debug.Log(totalDamage + " Generic Damage Taken");
    }

    private float CalculateTotalDamage(GenericDamage damage)
    {
        float totalDamage = 0;

        if (damage.physicalDamage > 0)
            Debug.Log("buraya geliyon mu");
            totalDamage += CalculateDamage(damage.physicalDamage, 0, true);
        if (damage.fireDamage > 0)
            totalDamage += CalculateDamage(damage.fireDamage, fireResistance);
        if (damage.coldDamage > 0)
            totalDamage += CalculateDamage(damage.coldDamage, coldResistance);
        if (damage.lightningDamage > 0)
            totalDamage += CalculateDamage(damage.lightningDamage, lightningResistance);
        if (damage.poisonDamage > 0)
            totalDamage += CalculateDamage(damage.poisonDamage, poisonResistance);

        return totalDamage;
    }

    private float CalculateDamage(float amount, int resistance, bool isPhysical = false)
    {
        if (isPhysical)
        {
            return CalculatePhysicalDamageMitigation(amount);
        }
        else
        {
            float damageMultiplier = 1.0f - Mathf.Clamp((float)resistance / 100.0f, 0.0f, 0.9f);
            return amount * damageMultiplier;
        }
    }

    public void Heal(float amount)
    {
        currentHealth += (int)amount;
        Debug.Log(amount + " HP Healed");
    }

    private float CalculatePhysicalDamageMitigation(float amount)
    {
        // Calculate the mitigation percentage based on armor and level
        float mitigationPercentage = Mathf.Clamp((float)armour / (10 * level) * 0.01f, 0.0f, 0.9f);

        // Calculate the final damage to take after applying the mitigation
        float physDamageToTake = amount * (1.0f - mitigationPercentage);

        // Return the final damage
        return physDamageToTake;
    }

    public void DealDamage(IDamageable target, GenericDamage damage)
    {
        target.TakeDamage(damage);
    }
}
