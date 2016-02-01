using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	public void Reset()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	public void Menu()
	{
		Application.LoadLevel ("menu");
	}

	void onEnable()
	{
		GameObject.FindGameObjectWithTag ("GameScore").GetComponent<GameScore> ().SaveScore ();
	}
}
