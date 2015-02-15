using UnityEngine;
using System.Collections;

public class GoMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		Camera.main.audio.Stop ();
		this.audio.Play ();
		Invoke ("LoadMainMenu", this.audio.clip.length);
	}
	
	void LoadMainMenu() {
		Application.LoadLevel ("Title");
	}
}
