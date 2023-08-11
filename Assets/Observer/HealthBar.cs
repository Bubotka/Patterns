using UnityEngine;
using UnityEngine.UI;

namespace Observer
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private Slider _slider;

        private float _maxHelth;

        private void Awake()
        {
            _player.HealthChanged += UpdateUI;
            _maxHelth = _player.Health;
        }


        private void OnDestroy() => 
            _player.HealthChanged -= UpdateUI;

        private void UpdateUI() => 
            _slider.value = _player.Health / _maxHelth;
    }
}