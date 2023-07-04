using UnityEngine;

namespace Strategy
{
    class DogMoveBehavior : IMove
    {
        public void Move()
        {
            Debug.Log("Cобака ходит");
        }
    }
}