using UnityEngine;
using UnityEngine.UI;

public class NavbarController : MonoBehaviour
{
    public Button[] navButtons;         // Assign in inspector
    public GameObject[] windows;        // Corresponding windows (same order as buttons)

    void Start()
    {
        for (int i = 0; i < navButtons.Length; i++)
        {
            int index = i; // local copy for the lambda
            navButtons[i].onClick.AddListener(() => OnNavButtonClicked(index));
        }

        // Optional: Initialize with first selected
        OnNavButtonClicked(0);
    }

    void OnNavButtonClicked(int index)
    {
        for (int i = 0; i < navButtons.Length; i++)
        {
            // Toggle window visibility
            windows[i].SetActive(i == index);

            
            Transform parent = navButtons[i].transform; // The "Parent" object
            Transform firstChild = parent.GetChild(0);   // FirstChild
            Transform firstChildChild = firstChild.GetChild(0); // FirstChildChild


            Image indicator = firstChildChild.GetComponent<Image>();

            Color color = indicator.color;
            color.a = (i == index) ? 1f : 0f;
            indicator.color = color;


        }
    }
}
