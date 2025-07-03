using UnityEngine;

public class ScrollSelectionManager : MonoBehaviour
{
    private SelectableVRButton currentSelected;

    public void OnButtonClicked(SelectableVRButton clicked)
    {
        if (currentSelected != null && currentSelected != clicked)
        {
            currentSelected.SetSelected(false);
        }

        currentSelected = clicked;
        currentSelected.SetSelected(true);
    }
}
