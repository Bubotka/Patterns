using UnityEngine;

namespace StateMachine
{
    public class InputService : MonoBehaviour
    {
        [SerializeField] private PlayerStateMachine _stateMachine;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q)) 
                _stateMachine.ChangeState<PlayerIdleState>();
            
            if (Input.GetKeyDown(KeyCode.W)) 
                _stateMachine.ChangeState<PlayerWalkState>();
            
            if (Input.GetKeyDown(KeyCode.E)) 
                _stateMachine.ChangeState<PlayerAttackState>();
        }
    }
}
