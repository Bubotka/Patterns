using System;
using UnityEngine;

namespace Factory
{
    public class Client : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                MageFactory factory = new FireMageFactory();

                Mage mage = factory.CreateMage();
                
                mage.CastSpell();
            }
            
            if (Input.GetKeyDown(KeyCode.I))
            {
                MageFactory factory = new IceMageFactory();

                Mage mage = factory.CreateMage();
                
                mage.CastSpell();
            }
        }
    }
}