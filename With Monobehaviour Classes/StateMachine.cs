public class StateMachine : MonoBehaviour
{
    public BaseState AttackState;
    public BaseState JumpState;

    private BaseState currentState;
    
    private void Awake()
    {
        AttackState = GetComponent<AttackState>();
        JumpState = GetComponent<JumpState>();
    }
    
    private void Update()
    {
        currentState.OnStay(this);
    }

    public void SetState(BaseState newBaseState)
    {
        currentState.OnExit(this);

        currentState = newBaseState;

        currentState.OnEnter(this);
    }
}