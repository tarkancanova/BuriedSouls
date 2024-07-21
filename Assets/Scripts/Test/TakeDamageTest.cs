using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class TakeDamageTest : MonoBehaviour
{
    [SerializeField] private Player _player;
    CharacterBase.GenericDamage lightningPhysical;
    CharacterBase.GenericDamage lightningCold;
    CharacterBase.GenericDamage lightning;
    CharacterBase.GenericDamage physical;

    private void Awake()
    {
        lightningPhysical = new CharacterBase.GenericDamage
        {
            physicalDamage = 10,
            fireDamage = 0,
            coldDamage = 0,
            lightningDamage = 10,
            poisonDamage = 0
        };

        lightningCold = new CharacterBase.GenericDamage
        {
            physicalDamage = 0,
            fireDamage = 0,
            coldDamage = 10,
            lightningDamage = 10,
            poisonDamage = 0
        };        
        lightning = new CharacterBase.GenericDamage
        {
            physicalDamage = 0,
            fireDamage = 0,
            coldDamage = 0,
            lightningDamage = 10,
            poisonDamage = 0
        };        
        physical = new CharacterBase.GenericDamage
        {
            physicalDamage = 10,
            fireDamage = 0,
            coldDamage = 0,
            lightningDamage = 0,
            poisonDamage = 0
        };
    }

    public void TakePhysicalLightningDamage()
    {
        _player.TakeDamage(lightningPhysical);
    }
    public void TakeLightningColdDamage()
    {
        _player.TakeDamage(lightningCold);
    }
    public void TakeLightningDamage()
    {
        _player.TakeDamage(lightning);
    }
    public void TakePhysicalDamage()
    {
        _player.TakeDamage(physical);
    }
}
