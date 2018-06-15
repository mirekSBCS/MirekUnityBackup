using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.UI;

public class HUD_Manager : MonoBehaviour {

	public int score;
	public Text ScoreText;
	public ThirdPersonCharacter ThirdPersonCharacter;

	// Use this for initialization
	void Start () {
		ThirdPersonCharacter = GameObject.Find ("Player").GetComponent<ThirdPersonCharacter> ();
		score = 0;
		ScoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	public void UpdateScore (int points) {
		score = score + points;
		ScoreText.text = "Score: " + score;
	}

	public void UpdateStats (float JumpIncrease, float SpeedIncrease){
		ThirdPersonCharacter.m_JumpPower += JumpIncrease;
		ThirdPersonCharacter.m_MoveSpeedMultiplier += SpeedIncrease;
	}
}
