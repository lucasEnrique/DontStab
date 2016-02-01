using UnityEngine;
using System.Collections;

public class voodooDie : MonoBehaviour {

    public void GameOver()
    {
        GameObject.FindGameObjectWithTag("life").GetComponent<LifeControl>().gameOver();
    }
}
