using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string itemName;
    public enum ItemType { Weapon, Helmet, OffHand, Ring, Amulet, Gloves, Boots, BodyArmor }
    public ItemType itemType;
    public int itemID;
    public List<ItemMods> mods = new List<ItemMods>();

    public Item(string name, ItemType itemType, int id, List<ItemMods> mods)
    {
        this.itemName = name;
        this.itemType = itemType;
        this.itemID = id;
        this.mods = mods;
    }

    public void ApplyMods(Player player)
    {
        foreach (var mod in mods)
        {
            mod.ApplyMod(player, mod.GetRandomValue());
        }
    }

    public void RemoveMods(Player player)
    {
        foreach (var mod in mods)
        {
            mod.ApplyMod(player, -mod.GetRandomValue());
        }
    }
}

