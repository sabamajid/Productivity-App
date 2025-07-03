using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class SelectableVRButton : MonoBehaviour, IPointerClickHandler
{
    public ScrollSelectionManager manager;

    public GameObject selectedImage;
    public GameObject deselectedImage;
    public TextMeshProUGUI buttonText;

    private Image bgImage;

    private Color selectedBgColor = new Color32(0x0F, 0x7C, 0xE3, 0xFF);   // Blue background
    private Color unselectedBgColor = Color.white;                        // White background

    private Color selectedTextColor = Color.white;                        // White text on blue
    private Color unselectedTextColor = new Color32(0x37, 0x4E, 0x65, 0xFF); // #374E65 on white

    void Awake()
    {
        bgImage = GetComponent<Image>();
        SetSelected(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        manager.OnButtonClicked(this);
    }

    public void SetSelected(bool isSelected)
    {
        if (bgImage != null)
            bgImage.color = isSelected ? selectedBgColor : unselectedBgColor;

        selectedImage?.SetActive(isSelected);
        deselectedImage?.SetActive(!isSelected);

        if (buttonText != null)
            buttonText.color = isSelected ? selectedTextColor : unselectedTextColor;
    }
}
