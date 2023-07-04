using UnityEngine;

namespace AbstractFactory
{
    class FireUnitsFactory : UnitsFactory
    {
        public override Mage CreateMage()
        {
            GameObject prefab = Resources.Load<GameObject>("FireMage");
            GameObject mage = GameObject.Instantiate(prefab, new Vector3(-1, 0, 0), Quaternion.identity);
            return mage.GetComponent<FireMage>();
        }

        public override Knight CreateKnight()
        {
            GameObject prefab = Resources.Load<GameObject>("FireKnight");
            GameObject knight = GameObject.Instantiate(prefab, new Vector3(-2, 0, 0), Quaternion.identity);
            return knight.GetComponent<FireKnight>();
        }

        public override Archer CreateArcher()
        {
            GameObject prefab = Resources.Load<GameObject>("FireArcher");
            GameObject archer = GameObject.Instantiate(prefab, new Vector3(-3, 0, 0), Quaternion.identity);
            return archer.GetComponent<FireArcher>();
        }
    }
}