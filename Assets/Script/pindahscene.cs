using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class pindahscene : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Escape))
			Application.Quit ();
		
	}

	public void PindahScene (string scenename){
			SceneManager.LoadScene (scenename);
	}
	public void mute(){
		AudioListener.pause = !AudioListener.pause;
	}
}
