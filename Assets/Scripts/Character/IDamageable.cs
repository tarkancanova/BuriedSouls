using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Enums;

public interface IDamageable
{
    public void TakeDamage(Player.GenericDamage genericDamage);
    public void Heal(float amount);
}
