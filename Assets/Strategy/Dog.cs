using UnityEngine;

namespace Strategy
{
    class Dog : AnimalBase
    {
        private void Start()
        {
            SetMoveBehavior(new DogMoveBehavior());
            SetSpeakBehavior(new BawBehavior());
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                Move();
                Speak();
            }
        }
    }
}