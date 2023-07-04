using UnityEngine;

namespace AbstractFactory
{
    class IceArcher : Archer
    {
        public override void Shoot()
        {
            Debug.Log("Ice shoot");
        }
    }
}