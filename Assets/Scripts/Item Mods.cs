using UnityEngine;

[CreateAssetMenu(fileName = "New Mod", menuName = "Inventory/Mod")]
public class ItemMod : ScriptableObject
{
    public string modName;
    public int minValue;
    public int maxValue;

    public int GetRandomValue()
    {
        return Random.Range(minValue, maxValue);
    }
}
