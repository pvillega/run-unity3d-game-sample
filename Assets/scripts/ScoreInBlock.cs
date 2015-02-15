using UnityEngine;
using System.Collections;

public class ScoreInBlock : MonoBehaviour {

	private bool hasCollidedWithPlayer = false;
	public int pointsPerPlatform = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collider) {
		if (!hasCollidedWithPlayer && collider.collider.tag == "Player") {
			string name = collider.contacts[0].collider.gameObject.name;
			if("RightFoot" == name || "LeftFoot" == name) {
				NotificationCenter.DefaultCenter().PostNotification(this, "ScorePoints", pointsPerPlatform);
				hasCollidedWithPlayer = true;
			}
		}
	}
}
