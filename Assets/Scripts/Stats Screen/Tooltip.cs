using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tooltip : MonoBehaviour
{
    public static Tooltip Instance;

    public GameObject tooltipPanel;
    public TMP_Text tooltipText;
    private RectTransform tooltipRect;

    public Vector2 offset = new Vector2(10, -10); // Offset to prevent tooltip from covering the mouse

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        tooltipPanel.SetActive(false);
        tooltipRect = tooltipPanel.GetComponent<RectTransform>();

        // Disable interaction with the tooltip panel to prevent triggering OnPointerExit
        CanvasGroup canvasGroup = tooltipPanel.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = tooltipPanel.AddComponent<CanvasGroup>();
        }
        canvasGroup.blocksRaycasts = false;
    }

    public void ShowTooltip(string message)
    {
        tooltipPanel.SetActive(true);
        tooltipText.text = message;
        UpdateTooltipPosition();
    }

    public void HideTooltip()
    {
        tooltipPanel.SetActive(false);
    }

    private void Update()
    {
        if (tooltipPanel.activeSelf)
        {
            UpdateTooltipPosition();
        }
    }

    private void UpdateTooltipPosition()
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            tooltipRect.parent as RectTransform,
            Input.mousePosition,
            null,
            out localPoint
        );
        localPoint += offset; // Apply the offset
        tooltipRect.localPosition = localPoint;
    }
}
