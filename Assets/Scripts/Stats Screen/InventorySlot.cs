using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Inventory inventory;
    public string textToShowOnItemExists;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (inventory.GetItemInSlot(this.name) == null) Tooltip.Instance.ShowTooltip("No item equipped in " + this.name + " slot.");
        else
        {

            textToShowOnItemExists = inventory.GetItemInSlot(this.name).itemType.ToString() + "\n";
            for (int i = 0; i < inventory.GetItemInSlot(this.name).mods.Count; i++)
            {
                textToShowOnItemExists += inventory.GetItemInSlot(this.name).mods[i].ToString() + "\n";
            }
            Tooltip.Instance.ShowTooltip(textToShowOnItemExists);

        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Tooltip.Instance.HideTooltip();
        textToShowOnItemExists = null;
    }
}