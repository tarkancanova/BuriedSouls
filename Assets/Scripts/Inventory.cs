using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Inventory : MonoBehaviour
{
    private Dictionary<string, Item> equipmentSlots;

    private void Start()
    {
        equipmentSlots = new Dictionary<string, Item>
        {
            { "helmet", null },
            { "body armor", null },
            { "weapon", null },
            { "ring1", null },
            { "ring2", null },
            { "amulet", null },
            { "off-hand", null },
            { "gloves", null },
        };
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
