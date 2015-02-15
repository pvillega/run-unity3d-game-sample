using UnityEngine;
using System.Collections;

public class itemScore : MonoBehaviour {

	public int pointsPerItem = 5;
	public AudioClip audioClip;
	private float soundVolume = 0.5f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "Player") {
			AudioSource.PlayClipAtPoint(audioClip, Camera.main.transform.position, soundVolume);
			NotificationCenter.DefaultCenter().PostNotification(this, "ScorePoints", pointsPerItem);
		}
		Destroy(this.gameObject);
	}
}
