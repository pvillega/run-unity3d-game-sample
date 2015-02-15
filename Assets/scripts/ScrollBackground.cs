using UnityEngine;
using System.Collections;

public class ScrollBackground : MonoBehaviour {

	public float speed = 0f;
	private bool moving = false;
	private float startTime = 0f;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "StartRunning");
		NotificationCenter.DefaultCenter ().AddObserver (this, "DeadCharacter");
	}
	
	// Update is called once per frame
	void Update () {
		if (moving) {
			float pos = ((Time.time - startTime) * speed) % 1;
			renderer.material.mainTextureOffset = new Vector2 (pos, 0);
		}
	}

	void StartRunning(Notification notification) {
		moving = true;
		startTime = Time.time;
	}

	void DeadCharacter() {
		moving = false;
	}
}
