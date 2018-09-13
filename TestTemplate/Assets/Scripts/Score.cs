using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Transform player;
    public Text scoreText;
    private float myScore;
	void Update () {
        myScore = player.position.z + 6f;
        scoreText.text = myScore.ToString("0");
	}
}
