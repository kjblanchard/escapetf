using System;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    public virtual void StartState(){}
    public virtual void Tick(){}
    public virtual void EndState(){}
    public virtual void ResetState(){}
}
