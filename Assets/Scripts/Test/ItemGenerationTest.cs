using UnityEngine;

public class TestItemGeneration : MonoBehaviour
{
    public Player player;

    void Start()
    {
        // Test for a weapon item
        Item randomWeapon = ItemManager.instance.CreateRandomItem("Random Sword", Item.ItemType.Weapon, 1);
        Debug.Log("Generated Weapon: " + randomWeapon.itemName + " with " + randomWeapon.mods.Count + " mods.");
        foreach (var mod in randomWeapon.mods)
        {
            Debug.Log("Mod: " + mod.modName + "Type: " + randomWeapon.itemType.ToString());
        }
        player.EquipItem(randomWeapon.itemType.ToString(), randomWeapon);

        // Test for an armor item
        //Item randomHelmet = ItemManager.instance.CreateRandomItem("Random Helmet", Item.ItemType.Helmet, 2);
        //Debug.Log("Generated Helmet: " + randomHelmet.itemName + " with " + randomHelmet.mods.Count + " mods.");
        //foreach (var mod in randomHelmet.mods)
        //{
        //    Debug.Log("Mod: " + mod.modName + " Value: " + mod.GetRandomValue());
        //}
        //player.EquipItem(randomHelmet);
    }
}