using TMPro;
using UnityEngine;
using ByteCollector.Gameplay;

namespace ByteCollector.UI
{
    public class LivesHud : MonoBehaviour
    {
        [SerializeField] private PlayerHealth playerHealth;
        [SerializeField] private TMP_Text livesText;

        private void OnEnable()
        {
            if (playerHealth != null) playerHealth.OnLivesChanged += UpdateText;
        }

        private void OnDisable()
        {
            if (playerHealth != null) playerHealth.OnLivesChanged -= UpdateText;
        }

        private void UpdateText(int lives)
        {
            if (livesText != null) livesText.text = $"Vidas: {lives}";
        }
    }
}
