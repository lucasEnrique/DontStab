using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreEnable : MonoBehaviour {

	// Use this for initialization
	void OnEnable () {
        if (gameObject.name == "ScoreText")
        {
//            GetComponent<Text>().text = (PlayerPrefs.GetInt("BestScore") + 1).ToString();
            GetComponent<Text>().text = GameObject.FindGameObjectWithTag("GameScore").GetComponent<GameScore>().getScore().ToString();
        }
        if (gameObject.name == "BestScore")
        {
            GetComponent<Text>().text = (PlayerPrefs.GetInt("BestScore")+1).ToString();
        }

       // this.gameObject.SetActive(false);


    }

}
