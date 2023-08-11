using UnityEngine;

namespace StateMachine
{
    class PlayerIdleState : IPlayerState
    {
        public void Enter()
        {
            Debug.Log("Player enter IdleState");
        }

        public void Exit()
        {
            Debug.Log("Player exit IdleState");
        }

        public void Update()
        {
            Debug.Log("Player in IdleState");
        }
    }
}