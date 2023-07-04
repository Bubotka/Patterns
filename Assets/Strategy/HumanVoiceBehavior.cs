using UnityEngine;

namespace Strategy
{
    class HumanVoiceBehavior : ISpeak
    {
        public void Speak()
        {
            Debug.Log("Человеческая речь");
        }
    }
}