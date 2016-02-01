using UnityEngine;
using System.Collections;

public class CallScene : MonoBehaviour
{
	public string Scene;

	void Splash(){
		Application.LoadLevel (Scene);
	}
}
