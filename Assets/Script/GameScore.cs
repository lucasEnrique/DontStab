using UnityEngine;
using System.Collections;

public class GameScore : MonoBehaviour {

	private int _score;
	// Use this for initialization
	void Start () {
		_score = 0;
	}

	public void addScore()
	{
		_score ++;
	}

	public void SaveScore()
	{
		if (PlayerPrefs.GetInt ("BestScore") < _score) 
		{
			PlayerPrefs.SetInt("BestScore", _score);
		}

		PlayerPrefs.SetInt("YourScore", _score);
	}

    public int getScore()
    { return _score; }


}
