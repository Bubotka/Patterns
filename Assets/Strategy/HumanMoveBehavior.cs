using UnityEngine;

namespace Strategy
{
    class HumanMoveBehavior : IMove
    {
        public void Move()
        {
            Debug.Log("Человеческая ходьба");
        }
    }
}