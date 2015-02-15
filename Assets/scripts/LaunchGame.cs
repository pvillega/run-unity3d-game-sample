using UnityEngine;
using System.Collections;

public class LaunchGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		Camera.main.audio.Stop ();
		this.audio.Play ();
		Invoke ("LoadNextLevel", this.audio.clip.length);
	}

	void LoadNextLevel() {
		Application.LoadLevel ("MainScene");
	}
}
