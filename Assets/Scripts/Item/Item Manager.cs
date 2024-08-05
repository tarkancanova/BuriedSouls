using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager instance;

    public List<ItemMods> weaponMods = new List<ItemMods>();
    public List<ItemMods> armorMods = new List<ItemMods>();
    public List<ItemMods> accessoryMods = new List<ItemMods>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Item CreateRandomItem(string name, Item.ItemType itemType, int id)
    {
        List<ItemMods> mods = GenerateRandomMods(itemType);
        return new Item(name, itemType, id, mods);
    }

    private List<ItemMods> GenerateRandomMods(Item.ItemType itemType)
    {
        List<ItemMods> mods = new List<ItemMods>();
        HashSet<int> usedModIndexes = new HashSet<int>();
        int modCount = Random.Range(1, 4);
        List<ItemMods> modPool = GetModPool(itemType);

        while (mods.Count < modCount && usedModIndexes.Count < modPool.Count)
        {
            int randomIndex = Random.Range(0, modPool.Count);
            if (!usedModIndexes.Contains(randomIndex))
            {
                ItemMods mod = modPool[randomIndex];
                mod.value = Random.Range(mod.minValue, mod.maxValue);
                mods.Add(mod);
                usedModIndexes.Add(randomIndex);
            }
        }

        return mods;
    }

    private List<ItemMods> GetModPool(Item.ItemType itemType)
    {
        switch (itemType)
        {
            case Item.ItemType.Weapon:
                return weaponMods;
            case Item.ItemType.OffHand:
            case Item.ItemType.Helmet:
            case Item.ItemType.BodyArmor:
            case Item.ItemType.Gloves:
            case Item.ItemType.Boots:
                return armorMods;
            case Item.ItemType.Ring:
            case Item.ItemType.Amulet:
                return accessoryMods;
            default:
                return new List<ItemMods>();
        }
    }
}