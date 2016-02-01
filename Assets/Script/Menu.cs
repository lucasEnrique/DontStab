using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    [SerializeField]
    private string play, info;

    [SerializeField]
   // private GameObject _loading;

    void Start()
    {
      //  _loading.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void PlayButton()
    {
       // _loading.SetActive(true);
        //Application.LoadLevel(play);
        StartCoroutine(setPlay(play));
    }

    public void InfoButton()
    {
        //_loading.SetActive(true);
        StartCoroutine(setPlay(info));

    }

    IEnumerator setPlay(string entrada)
    {
        AsyncOperation async = Application.LoadLevelAsync(entrada);
        yield return async;
    }


}
