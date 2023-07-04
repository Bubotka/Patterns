using UnityEngine;

namespace AbstractFactory
{
    public class Client : MonoBehaviour
    {
        private UnitsFactory _factory;
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Z))
            {
                _factory = new FireUnitsFactory();
            }
            
            if(Input.GetKeyDown(KeyCode.X))
            {
                _factory = new IceUnitsFactory();
            }
            
            if(Input.GetKeyDown(KeyCode.Q))
            {
                _factory.CreateKnight().Attack();
            }
            
            if(Input.GetKeyDown(KeyCode.W))
            {
                _factory.CreateMage().CastSpell();
            }
            
            if(Input.GetKeyDown(KeyCode.E))
            {
                _factory.CreateArcher().Shoot();
            }
        }
    }
}