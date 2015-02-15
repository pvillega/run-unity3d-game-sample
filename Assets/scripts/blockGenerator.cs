using UnityEngine;
using System.Collections;

public class blockGenerator : MonoBehaviour {

	public GameObject[] blocks;
	public float minTime = 1.5f;
	public float maxTime = 3f;
	private bool isAlive = true;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "StartRunning");
		NotificationCenter.DefaultCenter ().AddObserver (this, "DeadCharacter");
	}
	
	// Update is called once per frame
	void Update () {

	}

	void StartRunning(Notification notification) {
		GenerateBlock ();
	}

	void GenerateBlock() {
		if (isAlive) {
			int pos = Random.Range (0, blocks.Length);
			Instantiate (blocks [pos], transform.position, Quaternion.identity);
			Invoke ("GenerateBlock", Random.Range (minTime, maxTime));
		}
	}

	void DeadCharacter() {
		isAlive = false;
	}
}
