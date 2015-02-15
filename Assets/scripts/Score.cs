using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	private int key = 0;
	private int _score = 0;
	public int score {
		get { return _score ^ key;}

		set { 
			key = Random.Range(0, int.MaxValue);
			_score = value ^ key;
		}
	}
	public TextMesh scoreBoard;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "ScorePoints");
		NotificationCenter.DefaultCenter ().AddObserver (this, "DeadCharacter");
		UpdateScore ();
	}

	void ScorePoints(Notification notification) {
		int points = (int) notification.data;
		score += points;
		UpdateScore ();
	}

	void UpdateScore() {
		scoreBoard.text = score.ToString();
	}

	void DeadCharacter() {
		if (score > GameState.gameState.maxScore) {
			GameState.gameState.maxScore = score;
			GameState.gameState.Save();
		}

		//send score to Google Play
		Social.ReportScore (score, "CgkIhIXXu7gbEAIQBg", (bool success) => {});
		if (score >= 25) {
			Social.ReportProgress("CgkIhIXXu7gbEAIQAQ", 100f, (bool success) => {});
		}
		if (score >= 50) {
			Social.ReportProgress("CgkIhIXXu7gbEAIQAg", 100f, (bool success) => {});
		}
		if (score >= 100) {
			Social.ReportProgress("CgkIhIXXu7gbEAIQAw", 100f, (bool success) => {});
		}
		if (score >= 150) {
			Social.ReportProgress("CgkIhIXXu7gbEAIQBA", 100f, (bool success) => {});
		}
		if (score >= 200) {
			Social.ReportProgress("CgkIhIXXu7gbEAIQBQ", 100f, (bool success) => {});
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
