using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Enums;

[CreateAssetMenu(fileName = "Passive", menuName = "New Passive Skill")]

public class PassivePoints : ScriptableObject
{
    public string passiveName;
    public string descriptionIfNeeded;
    public bool descriptionNeeded;
    public PassivePoint passivePoint;
    public int levelReq;
    public bool allocated;

    public void ApplyPassivePoint(Player player)
    {
        switch (passivePoint)
        {
            case PassivePoint.Armour:
                player.armour += 100;
                break;            
            case PassivePoint.EvasionRating:
                player.evasionRating += 100;
                break;            
            case PassivePoint.LightningResistance:
                player.lightningResistance += 100;
                break;            
            case PassivePoint.FireResistance:
                player.fireResistance += 100;
                break;            
            case PassivePoint.ColdResistance:
                player.coldResistance += 10;
                break;            
            case PassivePoint.Dexterity:
                player.dexterity += 100;
                break;            
            case PassivePoint.Strength:
                player.strength += 100;
                break;            
            case PassivePoint.Intelligence:
                player.intelligence += 100;
                break;
        }
    }
}
