using UnityEngine;
using System.Collections;

public class HeartCollider : MonoBehaviour
{
    LifeControl life;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag.Equals("Faca"))
        {
            life.dano();
        }
       
    }


    // Use this for initialization
    void Start()
    {
        life = GameObject.FindGameObjectWithTag("life").GetComponent<LifeControl>();
    }


}
