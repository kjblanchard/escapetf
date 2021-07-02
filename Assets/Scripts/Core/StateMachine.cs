using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private State _currentState;
    private State _previousState;

    void Update()
    {
        if (_currentState != null)
            _currentState.Tick();
    }

    public void ChangeState(State stateToChangeTo)
    {
        if (_currentState != null)
        {
            _previousState.EndState();
            _previousState = _currentState;
        }
        _currentState = stateToChangeTo;
        _currentState.StartState();
    }

}
