using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Inventory inventory;
    public string textToShowOnItemExists;

    private void OnEnable()
    {
        var test = inventory.GetItemInSlot(this.name);
        if (test != null)
            this.GetComponent<Image>().color = Color.red;
        else
            this.GetComponent<Image>().color = Color.gray;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (inventory.GetItemInSlot(this.name) == null) Tooltip.Instance.ShowTooltip("No item equipped in " + this.name + " slot.");
        else
        {

            textToShowOnItemExists = inventory.GetItemInSlot(this.name).itemType.ToString() + "\n";
            for (int i = 0; i < inventory.GetItemInSlot(this.name).mods.Count; i++)
            {
                textToShowOnItemExists += inventory.GetItemInSlot(this.name).mods[i].value + "%" + " " + inventory.GetItemInSlot(this.name).mods[i].modName + "\n";
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