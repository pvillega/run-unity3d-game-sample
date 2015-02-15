using UnityEngine;
using System.Collections;

public class itemGenerator : MonoBehaviour {

	public GameObject item;
	public float minTime = 2f;
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
		GenerateItem ();
	}
	
	void GenerateItem() {
		if (isAlive) {
			Instantiate (item, transform.position, Quaternion.identity);
			Invoke ("GenerateItem", Random.Range (minTime, maxTime));
		}
	}

	void DeadCharacter() {
		isAlive = false;
	}
}
