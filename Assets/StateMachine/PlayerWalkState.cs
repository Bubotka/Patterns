using UnityEngine;

namespace StateMachine
{
    class PlayerWalkState : IPlayerState
    {
        public void Enter()
        {
            Debug.Log("Player enter WalkState");
        }

        public void Exit()
        {
            Debug.Log("Player exit WalkState");
        }

        public void Update()
        {
            Debug.Log("Player in WalkState");
        }
    }
}