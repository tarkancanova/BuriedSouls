using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacterBase
{
    public int intelligence; //increases elemental damage %5 and max shield by 10 for every 10 points.
    public int strength; //increases physical damage by %5 and max hp by 10 for every 10 points.
    public int dexterity; //increases evasion by 10 & crit chance by %0.1 for every 10 points.
    public int attackDamage;
    public int criticalAvoidance;
    public Inventory inventory;
    private List<Item> equippedItems = new List<Item>();
    public int passivePoints;

    protected override void OnEnable()
    {
        maxHealth = 100;
        currentHealth = (int)maxHealth;
        attackDamage = 5;
        //level = _enemyData.level;
       // characterName = _enemyData.enemyName;
    }

    public void EquipItem(string slot, Item item)
    {
        inventory.EquipItem(slot, item);

        equippedItems.Add(item);

        item.ApplyMods(this);
    }

    public void UnequipItem(Item item)
    {
        if (equippedItems.Contains(item))
        {
            inventory.UnequipItem(item.itemType.ToString());
            item.RemoveMods(this);
            equippedItems.Remove(item);
        }
    }
}
