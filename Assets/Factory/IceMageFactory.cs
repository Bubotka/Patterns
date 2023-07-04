using UnityEngine;

namespace Factory
{
    class IceMageFactory : MageFactory
    {
        public override Mage CreateMage()
        {
            GameObject magePrefab = Resources.Load<GameObject>("IceMage");

            GameObject mage = Object.Instantiate(magePrefab,new Vector3(1,0,0),Quaternion.identity);

            IceMage component = mage.GetComponent<IceMage>();

            return component;
        }
    }
}