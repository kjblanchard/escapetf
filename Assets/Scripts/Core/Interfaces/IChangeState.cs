using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChangeState<T> where T: State
{
    public void ChangeState(T stateToChangeTo);

}
