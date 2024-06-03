using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : CharacterBase
{
    [SerializeField] private EnemySO _enemyData;

    protected override void OnEnable()
    {
        level = _enemyData.level;
        maxHealth = (_enemyData.maxHealth * level * 1.1f);
        Debug.Log(level + " " + maxHealth);
        Debug.Log(maxHealth);
        currentHealth = (int) maxHealth;
        level = _enemyData.level;
        characterName = _enemyData.enemyName;
        baseAttackDamage = _enemyData.baseAttackDamage;
    }

    public void Attack(Player player)
    {
        float damageToDeal = baseAttackDamage * level;
        Debug.Log(baseAttackDamage + " " + level);
        player.GetComponent<Player>().TakeDamage((int)damageToDeal);
    }
}
