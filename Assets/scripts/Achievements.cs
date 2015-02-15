using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class Achievements : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		this.audio.Play ();

		if (Social.localUser.authenticated) {
			((PlayGamesPlatform)Social.Active).ShowAchievementsUI();
		} else {
			Social.localUser.Authenticate((bool success) => {});
		}
	}
}
