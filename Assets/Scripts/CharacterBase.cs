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
    public int shield; //Renewed every turn
    public int evasionRating; //every (20*level) evasion rating adds %1 chance to evade attack. max value %90 //scaling for enemy will be dependent on enemy
    public int armour; //every (10*level) armour adds %1 physical damage mitigation. max value: %90 //scaling for enemy will be dependent on enemy
    public int fireResistance;     //max resistances are %90. resistance scaling for enemy will be dependent on enemy
    public int coldResistance;
    public int lightningResistance;
    public int poisonResistance;


    //every level increases max health by %10.
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
