using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSceneStateController : MonoBehaviour, IChangeState<MainMenuScreenState>
{
    [SerializeField] private StateMachine _stateMachine;
    public MainMenuOpenState MainMenuOpenState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeState(MainMenuScreenState stateToChangeTo)
    {
        _stateMachine.ChangeState(stateToChangeTo);
    }
}
