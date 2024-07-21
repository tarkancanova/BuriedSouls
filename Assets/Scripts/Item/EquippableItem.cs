using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquippableItem : MonoBehaviour
{
    public enum ItemType { Weapon, Helmet, OffHand, Ring, Amulet, Gloves, Boots, BodyArmor };
    public int itemID;
    public string description;
    public List<ItemMods> mods = new List<ItemMods>();

}
