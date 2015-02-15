using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class Ranking : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		this.audio.Play ();

		if (Social.localUser.authenticated) {
			((PlayGamesPlatform)Social.Active).ShowLeaderboardUI("CgkIhIXXu7gbEAIQBg");
		} else {
			Social.localUser.Authenticate((bool success) => {});
		}
	}
}
