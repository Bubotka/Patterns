using System;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine
{
    public class PlayerStateMachine : MonoBehaviour
    {
        public IPlayerState CurrentState;
        
        private Dictionary<Type, IPlayerState> _states;

        private void InitStates()
        {
            _states = new Dictionary<Type, IPlayerState>()
            {
                [typeof(PlayerIdleState)] = new PlayerIdleState(),
                [typeof(PlayerWalkState)] = new PlayerWalkState(),
                [typeof(PlayerAttackState)] = new PlayerAttackState(),
            };
        }

        private void Start()
        {
            InitStates();
            SetCurrentStateByDefault();
        }

        private void Update()
        {
             if(CurrentState!=null)
                 CurrentState.Update();
        }

        public void ChangeState<T>() where T:IPlayerState
        {
            var state = GetState<T>();
            SetState(state);
        }

        private void SetState(IPlayerState newState) 
        {
            if(CurrentState!= null) CurrentState.Exit();

            CurrentState = newState;
            CurrentState.Enter();
        }

        private void SetCurrentStateByDefault() => 
            ChangeState<PlayerIdleState>();

        private IPlayerState GetState<T>() where T : IPlayerState => 
            _states[typeof(T)];
        
        
    }
}