using UnityEngine;
using UnityEngine.SceneManagement;
using ByteCollector.Gameplay;

namespace ByteCollector.UI
{
    public class GameOverPanel : MonoBehaviour
    {
        [SerializeField] private PlayerHealth playerHealth;
        [SerializeField] private GameObject panel;
        [SerializeField] private string mainMenuSceneName = "01_MainMenu";

        private void OnEnable()
        {
            if (playerHealth != null) playerHealth.OnDeath += Show;
        }

        private void OnDisable()
        {
            if (playerHealth != null) playerHealth.OnDeath -= Show;
        }

        private void Start()
        {
            if (panel != null) panel.SetActive(false);
        }

        public void Show()
        {
            if (panel != null) panel.SetActive(true);
        }

        public void Retry()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void BackToMenu()
        {
            SceneManager.LoadScene(mainMenuSceneName);
        }
    }
}