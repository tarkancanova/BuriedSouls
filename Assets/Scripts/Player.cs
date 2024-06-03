using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacterBase
{
    public int intelligence; //increases elemental damage %5 and max mana by 10 for every 10 points.
    public int strength; //increases physical damage by %5 and max hp by 10 for every 10 points.
    public int dexterity; //increases evasion by 10 & crit chance by %0.1 for every 10 points.
    public int attackDamage;

    protected override void OnEnable()
    {
        maxHealth = 100;
        currentHealth = (int)maxHealth;
        attackDamage = 5;
        //level = _enemyData.level;
       // characterName = _enemyData.enemyName;
    }
}
