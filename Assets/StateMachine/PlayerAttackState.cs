using UnityEngine;

namespace StateMachine
{
    class PlayerAttackState : IPlayerState
    {
        public void Enter()
        {
            Debug.Log("Player enter AttackState");
        }

        public void Exit()
        {
            Debug.Log("Player exit AttackState");
        }

        public void Update()
        {
            Debug.Log("Player in AttackState");
        }
    }
}