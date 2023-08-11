using System;
using UnityEngine;

namespace Observer
{
    public class Player : MonoBehaviour
    {
        public float Health=100; 

        public event Action HealthChanged;


        private void Update()
        {
            if (Input.GetMouseButtonDown(0)) TakeDamage(10);
        }

        private void TakeDamage(float damage)
        {
            Health -= damage;
            HealthChanged.Invoke();
        }
    }
}