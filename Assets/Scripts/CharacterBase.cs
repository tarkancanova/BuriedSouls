using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour, IDamageable
{
    public int currentHealth;
    public float maxHealth;
    public int level;
    public int baseAttackDamage; //will be scaled with level for enemies and not only with level for player.
    public string characterName;
    //defensive stats
    public int maxShield; //initial value 0
    public int currentShield; //Will be equal to max shield at the start of every turn
    public int evasionRating; //every (20*level) evasion rating adds %1 chance to evade attack. max value %90 //scaling for enemy will be dependent on enemy
    public int armour; //every (10*level) armour adds %1 physical damage mitigation. max value: %90 //scaling for enemy will be dependent on enemy
    public int fireResistance;     //max resistances are %90. resistance scaling for enemy will be dependent on enemy
    public int coldResistance;
    public int lightningResistance;
    public int poisonResistance;
    public int critChance;
    public int criticalDamage; //defualt value = 2xDamage that would be dealt without critical strike
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


    //every level adds 10 to max health.
    //on level-up player gives 5 attribute points to attribute of their choice. XP will be dependent of enemy however slaying a boss will give XP 5x of average XP previous monsters.
    

    protected virtual void OnEnable()
    {

    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log(amount + " Damage Taken");
    }
    
    public void Heal(int amount)
    {
        currentHealth += amount;
        Debug.Log(amount + " HP Healed");
    }
}
