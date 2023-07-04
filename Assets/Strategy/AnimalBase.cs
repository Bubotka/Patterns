using System;
using UnityEngine;

namespace Strategy
{
    public abstract class AnimalBase : MonoBehaviour
    {
        protected IMove _moveBehavior;
        protected ISpeak _speakBehavior;

        public void SetMoveBehavior(IMove behavior) => _moveBehavior = behavior;
        public void SetSpeakBehavior(ISpeak behavior) => _speakBehavior = behavior;

        public void Move() => _moveBehavior.Move();
        public void Speak() => _speakBehavior.Speak();
    }
}