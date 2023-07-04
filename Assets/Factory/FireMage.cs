using UnityEngine;

namespace Factory
{
    class FireMage : Mage
    {
        public override void CastSpell()
        {
            Debug.Log("FireBall");
        }
    }
}