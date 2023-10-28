using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MainView
{
    public class MainView : MonoBehaviour
    {
        [SerializeField] private GameObject _mainUI;
        [SerializeField] private GameObject _settingsUI;

        [SerializeField] private Button _goToSettingsBtn;
        [SerializeField] private Button _goToNewGameBtn;
        void Start()
        {
            _goToSettingsBtn.onClick.AddListener(() => { ShowSettingsUI(); });
            _goToNewGameBtn.onClick.AddListener(() => { ShowNewGameUI(); });

            _settingsUI.SetActive(false);
        }

        public void ShowSettingsUI()
        {
            _mainUI.SetActive(false);
            _settingsUI.SetActive(true);
        }

        public void ShowNewGameUI()
        {
            SceneManager.LoadScene("Game");
        }
    }
}
