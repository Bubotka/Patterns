using UnityEngine;

namespace AbstractFactory
{
    class IceUnitsFactory : UnitsFactory
    {
        public override Mage CreateMage()
        {
            GameObject prefab = Resources.Load<GameObject>("IceMage");
            GameObject mage = GameObject.Instantiate(prefab, new Vector3(1, 0, 0), Quaternion.identity);
            return mage.GetComponent<IceMage>();
        }

        public override Knight CreateKnight()
        {
            GameObject prefab = Resources.Load<GameObject>("IceKnight");
            GameObject knight = GameObject.Instantiate(prefab, new Vector3(2, 0, 0), Quaternion.identity);
            return knight.GetComponent<IceKnight>();
        }

        public override Archer CreateArcher()
        {
            GameObject prefab = Resources.Load<GameObject>("IceArcher");
            GameObject archer = GameObject.Instantiate(prefab, new Vector3(3, 0, 0), Quaternion.identity);
            return archer.GetComponent<IceArcher>();
        }
    }
}