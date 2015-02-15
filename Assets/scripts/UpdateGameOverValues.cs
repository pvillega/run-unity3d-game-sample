using UnityEngine;
using System.Collections;

public class UpdateGameOverValues : MonoBehaviour {

	public TextMesh score;
	public TextMesh highScore;
	public Score scoreStore;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Called when camera is called
	void OnEnable() {
		if (scoreStore != null) {
			score.text = scoreStore.score.ToString ();
		}
		if (GameState.gameState != null) {
			highScore.text = GameState.gameState.maxScore.ToString ();
		}
	}
}
