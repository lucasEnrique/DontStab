using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreEnable : MonoBehaviour {

	// Use this for initialization
	void OnEnable () {
       GetComponent<Text>().text = GameObject.FindGameObjectWithTag("GameScore").GetComponent<GameScore>().getScore().ToString();
    }

}
