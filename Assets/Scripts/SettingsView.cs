using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsView : MonoBehaviour
{
    [SerializeField] private GameObject _mainUI;
    [SerializeField] private GameObject _settingsUI;

    [SerializeField] private Dropdown _resolutionDropdown;
    [SerializeField] private Toggle _fullscreenToggle;
    [SerializeField] private Button _goToMainMenu;

   
    void Start()
    {
        Screen.SetResolution(640, 480, 0);
    }

    public void SetScreenResolution()
    {
        bool _fullscreen = Screen.fullScreen;
        switch (_resolutionDropdown.value)
        {
            case 0:
                Screen.SetResolution(640, 480, _fullscreen);
                break;
            case 1:
                Screen.SetResolution(800, 600, _fullscreen);
                break;
            case 2:
                Screen.SetResolution(1020, 768, _fullscreen);
                break;
            case 3:
                Screen.SetResolution(1280, 1024, _fullscreen);
                break;
        }
    }
    public void SetFullScreen()
    {
        Screen.SetResolution(Screen.width, Screen.height, _fullscreenToggle.isOn);
    }
    public void GoToMainMenu()
    {
        _settingsUI.SetActive(false);
        _mainUI.SetActive(true);
    }
}
