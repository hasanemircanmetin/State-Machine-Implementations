using UnityEngine;

public class StateMachine : MonoBehaviour
{
    States currentState;

    void Update()
    {
        switch (currentState)
        {
            case States.State1:
                // Do something for State1
                break;
            case States.State2:
                // Do something for State2
                break;
            case States.State3:
                // Do something for State3
                break;
            default:
                // Do something if the state is not recognized
                break;
        }
    }
    
    public enum States
    {
        State1,
        State2,
        State3
    }
}