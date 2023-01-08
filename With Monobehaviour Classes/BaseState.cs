using UnityEngine;

public abstract class BaseState : MonoBehaviour
{
    public abstract void OnEnter(StateMachine stateMachine);

    public abstract void OnStay(StateMachine stateMachine);

    public abstract void OnExit(StateMachine stateMachine);
}