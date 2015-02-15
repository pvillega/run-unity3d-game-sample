using UnityEngine;
using System.Collections;

public class FollowChar : MonoBehaviour {

	public GameObject gameOver;
	public Transform character;
	public float padding = 6f;
	private bool isAlive = true;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "DeadCharacter");
	}
	
	// Update is called once per frame
	void Update () {
		if (isAlive) {
			transform.position = new Vector3 (character.position.x + padding, transform.position.y, transform.position.z);
		}
	}

	void DeadCharacter() {
		isAlive = false;
		gameOver.SetActive(true);
	}
}
