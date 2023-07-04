using UnityEngine;

namespace Strategy
{
    class BawBehavior : ISpeak
    {
        public void Speak()
        {
            Debug.Log("Лай собаки");
        }
    }
}