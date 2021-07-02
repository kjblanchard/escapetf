using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainMenuButtonController : MenuBoxController
{
    void Start()
    {
        _playerInput.enabled = true;
        foreach (var VARIABLE in _buttonsToControl)
        {
           if(!VARIABLE.IsActive) 
                VARIABLE.ButtonText.color = Color.gray;
        }

    }
    public void OnMoveDown()
    {
        HoverLeaveButton(_currentButtonSelection);
        MoveCursorDown();
        HoverButton(_currentButtonSelection);
    }
    public void OnMoveUp()
    {
        HoverLeaveButton(_currentButtonSelection);
        MoveCursorUp();
        HoverButton(_currentButtonSelection);
    }

    public void OnConfirm()
    {
        ClickButton(_currentButtonSelection);
    }
    public override void ClickButton(int buttonToSelect)
    {
        if (!_buttonsToControl[buttonToSelect].IsActive)
        {
            FMODUnity.RuntimeManager.PlayOneShot($"event:/{cancelSound}");
        }
        else
        {
            FMODUnity.RuntimeManager.PlayOneShot($"event:/{submitSound}");
            HandleButtonClick(buttonToSelect);
        }
    }

    public override void HoverButton(int buttonHovered)
    {
        SelectButton(buttonHovered);
    }

    public override void HoverLeaveButton(int buttonLeftHovered)
    {
        DeselectButton(buttonLeftHovered);
    }

    public override void SelectButton(int buttonToSelect)
    {
        var button = _buttonsToControl[buttonToSelect];
        if(button.IsSelected || !button.IsActive)
            return;
        DeselectButton(_currentButtonSelection);
        button.IsSelected = true;
        button.ButtonText.color = Color.yellow;
        button.ButtonText.fontStyle = FontStyles.Italic;
        _fingerGameObject.transform.position = _buttonsToControl[buttonToSelect].transform.position;
        _previousButtonSelection = _currentButtonSelection;
        _currentButtonSelection = buttonToSelect;
    }

    public override void DeselectButton(int buttonToDeselect)
    {
        var button = _buttonsToControl[buttonToDeselect];
        if(!button.IsSelected || !button.IsActive)
            return;
        button.IsSelected = false;
        button.ButtonText.color = Color.white;
        button.ButtonText.fontStyle = FontStyles.Normal;
    }

    public void HandleButtonClick(int buttonToClick)
    {
    }
}
