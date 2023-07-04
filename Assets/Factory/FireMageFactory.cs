using UnityEngine;

namespace Factory
{
    class FireMageFactory : MageFactory
    {
        public override Mage CreateMage()
        {
            GameObject magePrefab = Resources.Load<GameObject>("FireMage");

            GameObject mage = Object.Instantiate(magePrefab,new Vector3(-1,0,0),Quaternion.identity);

            FireMage component = mage.GetComponent<FireMage>();

            return component;
        }
    }
}