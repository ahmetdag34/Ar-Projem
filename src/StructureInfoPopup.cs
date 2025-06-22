using UnityEngine;
using UnityEngine.UI;

public class StructureInfoPopup : MonoBehaviour
{
    public GameObject popupPanel;
    public Text popupText;
    public Camera arCamera;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = arCamera.ScreenPointToRay(Input.GetTouch(0).position);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                GameObject selectedObject = hit.transform.gameObject;

                // Objeye özel kontrol
                if (selectedObject.name == "saint_basil's_cathedral")
                {
                    popupText.text = "Aziz Basil Katedrali, Rusya'nýn Moskova kentindedir...";
                    popupPanel.SetActive(true);
                }
                else if (selectedObject.name == "tajmahal")
                {
                    popupText.text = "Tac Mahal, Hindistan'da bulunan anýtsal bir mezardýr...";
                    popupPanel.SetActive(true);
                }
            }
        }
    }

    public void ClosePopup()
    {
        popupPanel.SetActive(false);
    }
}
