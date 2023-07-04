using UnityEngine;

namespace AbstractFactory
{
    class IceMage : Mage
    {
        public override void CastSpell()
        {
            Debug.Log("IceBall");
        }
    }
}