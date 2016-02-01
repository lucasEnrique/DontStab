using UnityEngine;
using System.Collections;

public class MoverFaca : MonoBehaviour {

	public Vector3 goTo, goBack;
    public GameObject sombra;

    [SerializeField]
	float timeToGo;

    SoundController _sound;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Center")
        {
            Return();
            sombra.SetActive(false);
        }
    }
	
	public void Stab(float delay)
	{
        gameObject.GetComponent<Collider2D>().enabled = true;
        gameObject.FadeTo(1f, 0.1f, 0f);
		gameObject.MoveTo(goTo, timeToGo, delay);
	}
    public void Return()
    {
     //   _sound.Stabwrong();
        GameObject.FindGameObjectWithTag("GameScore").GetComponent<GameScore>().addScore();
        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.FadeTo(0.0f, 0.2f, 0);
        gameObject.MoveTo(goBack, 0.1f, 0.3f);
    }

    void Start()
    {
        _sound = GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>();
    }
}
