using UnityEngine;
using System.Collections;

public class TitleScrollBackground : MonoBehaviour {

	public float speed = 0f;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float pos = (Time.time * speed) % 1;
		renderer.material.mainTextureOffset = new Vector2 (pos, 0);
	}

}
