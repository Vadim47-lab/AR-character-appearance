using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private AudioClip _buttonPress;

    public void OnContinueClick()
    {
        PlayMusic();
        _menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnExitClick()
    {
        PlayMusic();
        Application.Quit();
    }

    public void OnReturnMenuClick()
    {
        PlayMusic();
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void OnEscMenuClick()
    {
        PlayMusic();
        _menu.SetActive(true);
        Time.timeScale = 0;
    }

    private void PlayMusic()
    {
        GetComponent<AudioSource>().PlayOneShot(_buttonPress);
    }
}