using UnityEngine;

namespace AbstractFactory
{
    class IceKnight : Knight
    {
        public override void Attack()
        {
            Debug.Log("Ice attack");
        }
    }
}