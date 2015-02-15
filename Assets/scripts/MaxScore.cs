using UnityEngine;
using System.Collections;

public class MaxScore : MonoBehaviour {

	public TextMesh maxScoreBoard;
	
	// Use this for initialization
	void Start () {

	}

	void UpdateMaxScore(int points) {
		maxScoreBoard.text = "Max Score: " + points;
	}
	
	// Update is called once per frame
	void Update () {
		UpdateMaxScore (GameState.gameState.maxScore);
	}
}
