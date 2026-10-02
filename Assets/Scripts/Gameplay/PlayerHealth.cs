using System;
using UnityEngine;

namespace ByteCollector.Gameplay
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField, Min(1)] private int maxLives = 3;

        public int CurrentLives { get; private set; }

        public event Action<int> OnLivesChanged;
        public event Action OnDeath;

        private void Awake()
        {
            CurrentLives = maxLives;
        }

        private void Start()
        {
            OnLivesChanged?.Invoke(CurrentLives);
        }

        [ContextMenu("Take Damage (test)")]
        public void TakeDamage()
        {
            if (CurrentLives <= 0) return;

            CurrentLives--;
            OnLivesChanged?.Invoke(CurrentLives);

            if (CurrentLives == 0)
            {
                OnDeath?.Invoke();
            }
        }
    }
}