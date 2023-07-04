using UnityEngine;

namespace Factory
{
    class IceMage : Mage
    {
        public override void CastSpell()
        {
            Debug.Log("IceBall");
        }
    }
}