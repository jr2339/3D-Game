using UnityEngine;
using System.Collections;

public class ScoreManger : MonoBehaviour {

	public static ScoreManger instance;
	public int score;
	public int highScore;


	void Awake(){
		if(instance == null){
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		score = 0;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void incrementScore(){
		score += 1;

	}

	public void startScore(){
		InvokeRepeating ("incrementScore", 0.1f, 0.5f);
	}

	public void stopScore(){
		CancelInvoke ("startScore");
	}
}
