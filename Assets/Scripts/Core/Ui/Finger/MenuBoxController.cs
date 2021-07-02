using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public abstract class MenuBoxController : MonoBehaviour
{
    [SerializeField] protected GameObject _fingerGameObject;
    [SerializeField] protected Image _fingerImage;
    [SerializeField] protected Animator _fingerAnimator;
    [SerializeField] protected MenuBoxButton[] _buttonsToControl;
    [SerializeField] protected TMPro.TMP_Text[] _buttonTexts;
    [SerializeField] protected int _buttonRows;
    [SerializeField] protected int _buttonColumns;
    [SerializeField] protected string submitSound;
    [SerializeField] protected string cancelSound;

    [SerializeField] protected PlayerInput _playerInput;
    [SerializeField] protected bool _shouldWrapIfScrollingPast = true;
    protected int _currentButtonSelection;
    protected int _previousButtonSelection;



    public virtual void HoverButton(int buttonHovered)
    {

    }

    public virtual void HoverLeaveButton(int buttonLeftHovered)
    {

    }
    public virtual void DeselectButton(int buttonToDeselect)
    {

    }
    public virtual void SelectButton(int buttonToSelect)
    {

    }

    public virtual void ClickButton(int buttonToSelect)
    {

    }

    public void MoveCursorDown()
    {
        var potentialNextValue = _currentButtonSelection + _buttonRows;
        if (potentialNextValue >= _buttonsToControl.Length)
            potentialNextValue = _shouldWrapIfScrollingPast ? 0 : _buttonsToControl.Length;
        _currentButtonSelection = potentialNextValue;
        if(!_buttonsToControl[_currentButtonSelection].IsActive)
            MoveCursorDown();
    }
    public void MoveCursorUp()
    {
        var potentialNextValue = _currentButtonSelection - _buttonRows;
        if (potentialNextValue < 0)
            potentialNextValue = _shouldWrapIfScrollingPast ? _buttonsToControl.Length - 1 : 0;
        _currentButtonSelection = potentialNextValue;
        if(!_buttonsToControl[_currentButtonSelection].IsActive)
            MoveCursorUp();
    }

}
