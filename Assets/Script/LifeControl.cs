using UnityEngine;
using System.Collections;

public class LifeControl : MonoBehaviour {

	[SerializeField]
	GameObject[] faca;

	private int facada;
    private bool _morreu;
    GameObject voodoo;
    SoundController _sound;

	[SerializeField]
	GameObject GameOverPanel;
	// Use this for initialization
	void Start () {
        _morreu = false;
		facada = 0;
        voodoo = GameObject.FindGameObjectWithTag("voodoo");
        _sound = GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>();
        for (int i=0; i< faca.Length; i++)
		{
			faca[i].SetActive(false);
		}
       
	
	}

	public void dano()
	{
        if (!_morreu)
        {
            faca[facada].SetActive(true);
            facada++;
            if (facada == 3)
            {
                _sound.Scream();
                _morreu = true;
                voodoo.GetComponent<Animator>().SetTrigger("diehit");
                GameObject.FindGameObjectWithTag("GameController").SetActive(false);
                GameObject.FindGameObjectWithTag("GameScore").GetComponent<GameScore>().SaveScore();
            }
            else {
                voodoo.GetComponent<Animator>().SetTrigger("hit");
                _sound.Stab();
            }
        }


	}

	public void gameOver()
	{
        
		GameOverPanel.SetActive (true);

	}
}
