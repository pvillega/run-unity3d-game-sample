using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class GameState : MonoBehaviour {

	public static GameState gameState;
	public int maxScore = 0;

	void Awake() {
		if (gameState == null) {
			gameState = this;
			DontDestroyOnLoad (gameObject);

//			PlayGamesPlatform.DebugLogEnabled = true;
			PlayGamesPlatform.Activate();
		} else if(gameState != this) {
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		Load ();
		((PlayGamesPlatform)Social.Active).Authenticate ((bool success) => {}, true);
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void Save(){
		PlayerPrefs.SetInt("maxScore", gameState.maxScore);
	}
	
	void Load(){
		maxScore = PlayerPrefs.GetInt("maxScore", 0);
	}

}
