using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Data")]
public class EnemySO : ScriptableObject
{
    public int maxHealth;
    public int level;
    public int maxActionPerTurn;
    public string enemyName;
    public int baseAttackDamage;
}
