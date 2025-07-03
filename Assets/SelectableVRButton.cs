using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectableVRButton : MonoBehaviour, IPointerClickHandler
{
    public ScrollSelectionManager manager;

    public GameObject selectedImage;
    public GameObject deselectedImage;

    private Image bgImage;

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
            bgImage.color = isSelected ? new Color32(0x0F, 0x7C, 0xE3, 0xFF) : Color.white;

        selectedImage?.SetActive(isSelected);
        deselectedImage?.SetActive(!isSelected);
    }
}
