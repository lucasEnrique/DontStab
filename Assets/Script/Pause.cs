using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    private bool _onpause;

    [SerializeField]
    private GameObject pausePanel;
    [SerializeField]
    private GameObject shaderPanel;
    [SerializeField]
    private Button pauseButton;
    [SerializeField]
    private string scene;
    // Use this for initialization
    void Start () {
        shaderPanel.SetActive(false);
        pausePanel.SetActive(false);
        _onpause = false;
        Time.timeScale = 1.0f;
    }
    
    public void ResumeGame()
    {
        shaderPanel.SetActive(false);
        pausePanel.SetActive(false);
        pauseButton.gameObject.SetActive(true);
        Time.timeScale = 1.0f;
        _onpause = false;
        GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>().bgSoundPlay();
    }

    public void PauseGame()
    {
        shaderPanel.SetActive(true);
        pausePanel.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        Time.timeScale = 0.0f;
        _onpause = true;
        GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>().pauseSound();
    }

    public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void GoToScene()
    {
        Application.LoadLevel(scene);
    }
    public void Quit()
    {
        Application.Quit();
    }

}
