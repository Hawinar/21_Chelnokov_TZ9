using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreTMP;
    [SerializeField] private TextMeshProUGUI _livesTMP;
    [SerializeField] private TextMeshProUGUI _floorsTMP;
    [SerializeField] private TextMeshProUGUI _resultTMP;

    [SerializeField] private Button _closeBtn;
    [SerializeField] private Button _goToMainMenu;
    [SerializeField] private Button _restartBtn;

    [SerializeField] private GameObject _gameOverUI;

    private void Start()
    {
        _gameOverUI.SetActive(false);
        _closeBtn.onClick.AddListener(() => GoToMainMenu());
        _goToMainMenu.onClick.AddListener(() => GoToMainMenu());
        _restartBtn.onClick.AddListener(() => Restart());
    }

    private void Update()
    {
        GameManager.Floors = GameObject.FindGameObjectsWithTag("isFirstOnLand").Length + GameObject.FindGameObjectsWithTag("isOnLand").Length;
        GameManager.Score = GameManager.Floors * 200;

        _scoreTMP.text = GameManager.Score.ToString();
        _livesTMP.text = $"x{GameManager.Lives}";
        _floorsTMP.text = GameManager.Floors.ToString();

        if(GameManager.Lives == 0)
        {
            _gameOverUI.SetActive(true);
            _resultTMP.text = GameManager.Score.ToString();
        }
    }
    private void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    private void Restart()
    {
        GameManager.Reset();
        SceneManager.LoadScene("Game");
    }
}
