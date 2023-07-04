using UnityEngine;

namespace AbstractFactory
{
    class FireArcher : Archer
    {
        public override void Shoot()
        {
            Debug.Log("Fire shoot");
        }
    }
}