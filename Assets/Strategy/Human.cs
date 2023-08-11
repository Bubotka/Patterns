using System;
using StateMachine;
using UnityEngine;

namespace Strategy
{
    class Human : AnimalBase
    {
        private void Start()
        {
            SetMoveBehavior(new HumanMoveBehavior());
            SetSpeakBehavior(new HumanVoiceBehavior());
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                Move();
                Speak();
            }
        }
    }
}