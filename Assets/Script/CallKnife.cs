using UnityEngine;
using System.Collections;

public class CallKnife : MonoBehaviour {

    public GameObject faca;
    private MoverFaca script;
    
	public void PrepararAtaque (float delay) {
        faca.GetComponent<MoverFaca>().Stab(delay);
        
	}
}
