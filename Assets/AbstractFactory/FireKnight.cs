using UnityEngine;

namespace AbstractFactory
{
    class FireKnight : Knight
    {
        public override void Attack()
        {
            Debug.Log("Fire attack");
        }
    }
}