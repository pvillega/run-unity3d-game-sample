using UnityEngine;
using System.Collections;

public class eraseBlocks : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "Player") {
			Camera.main.audio.Stop();
			this.audio.Play();
			NotificationCenter.DefaultCenter ().PostNotification (this, "DeadCharacter");
			GameObject pj = GameObject.Find("character");
			pj.SetActive(false);
		} else {
			Destroy (collider.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
