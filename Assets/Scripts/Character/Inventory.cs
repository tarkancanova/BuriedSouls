using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Inventory : MonoBehaviour
{
    private Dictionary<string, Item> equipmentSlots;

    private void Awake()
    {
        equipmentSlots = new Dictionary<string, Item>
        {
            { "Helmet", null },
            { "BodyArmor", null },
            { "Weapon", null },
            { "Ring1", null },
            { "Ring2", null },
            { "Amulet", null },
            { "OffHand", null },
            { "Gloves", null },
            { "Boots", null },
        };

        //EquipItem("weapon", _weaponFactory.GetComponent<WeaponFactory>().CreateRandomizedWeapon("bgd", 1263, 4));
        //Debug.Log(GetItemInSlot("weapon").GetStats());

        
    }


    public void EquipItem(string slot, Item item)
    {
        if (equipmentSlots.ContainsKey(slot))
        {
            equipmentSlots[slot] = item;
        }
        else
        {
            Debug.Log(slot + " slot does not exist.");
        }
    }

    public void UnequipItem(string slot)
    {
        if (equipmentSlots.ContainsKey(slot) && equipmentSlots[slot] != null)
        {
            equipmentSlots[slot] = null;
        }
        else
        {
            Debug.Log("No item to unequip in " + slot + " slot.");
        }
    }

    public Item GetItemInSlot(string slot)
    {
        return equipmentSlots.ContainsKey(slot) ? equipmentSlots[slot] : null;
    }

    

}
