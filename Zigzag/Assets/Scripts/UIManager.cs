﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour {

	public static UIManager instance;


	public GameObject ZigzagPanel;
	public GameObject gameOverPanel;
	public GameObject tapText;
	public Text score;
	public Text highScorce1;
	public Text highScorce2;


	void Awake(){
		if(instance == null){
			instance = this;
		}
	}
	// Use this for initialization
	void Start () {
		highScorce1.text ="High Score: " + PlayerPrefs.GetInt ("highScore");
	}



	public void GameStart(){
		tapText.SetActive (false);
		ZigzagPanel.GetComponent<Animator>().Play ("panelUp");
	}

	public void GameOver(){
		score.text = PlayerPrefs.GetInt ("score").ToString();
		highScorce2.text = PlayerPrefs.GetInt ("highScore").ToString();
		gameOverPanel.SetActive (true);
	
	}

	public void Reset(){
		SceneManager.LoadScene (0);
	}

	// Update is called once per frame
	void Update () {

	}
}
