using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Inventory/Weapon")]
public class Weapon : ScriptableObject
{
    public string weaponName;
    public int weaponID;
    public string description;
    public List<ItemMod> mods = new List<ItemMod>();

    public void AddMod(ItemMod mod)
    {
        mods.Add(mod);
    }

    public void RandomizeMods(int modCount, List<ItemMod> modPool)
    {
        mods.Clear();
        for (int i = 0; i < modCount; i++)
        {
            ItemMod randomMod = modPool[Random.Range(0, modPool.Count)];
            mods.Add(randomMod);
        }
    }

    public string GetStats()
    {
        string stats = weaponName + " stats:\n";
        foreach (ItemMod mod in mods)
        {
            stats += mod.modName + ": " + mod.GetRandomValue() + "\n";
        }
        return stats;
    }
}
