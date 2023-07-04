using UnityEngine;

namespace AbstractFactory
{
    class FireMage : Mage
    {
        public override void CastSpell()
        {
            Debug.Log("FireBall");
        }
    }
}