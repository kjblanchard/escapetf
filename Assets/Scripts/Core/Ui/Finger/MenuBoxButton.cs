using UnityEngine;
using UnityEngine.EventSystems;

public class MenuBoxButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] public int ButtonNumber;
    [SerializeField] public TMPro.TMP_Text ButtonText;
    [SerializeField] public MenuBoxController MenuBoxController;
    public bool IsActive = true;
    public bool IsSelected = false;


    public void OnPointerEnter(PointerEventData eventData)
    {
        MenuBoxController.HoverButton(ButtonNumber);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        MenuBoxController.HoverLeaveButton(ButtonNumber);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        MenuBoxController.ClickButton(ButtonNumber);
    }
}
