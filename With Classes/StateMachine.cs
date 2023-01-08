using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public BaseState StateA;
    public BaseState StateB;
    
    private BaseState currentState;

    private void Awake()
    {
        StateA = new StateA();
        StateB = new StateB();
    }

    private void Start()
    {
        currentState = StateA;
    }

    public void Update()
    {
        currentState?.Update();
    }

    public void SetState(BaseState newState)
    {
        currentState.OnExit();
        currentState = newState;
        currentState.OnEnter();
    }
}