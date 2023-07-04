using UnityEngine;

namespace Factory
{
   public abstract class Mage : MonoBehaviour
   {
      private float _hp;
      private float _mp;
   
      public abstract void CastSpell();
   }
}
