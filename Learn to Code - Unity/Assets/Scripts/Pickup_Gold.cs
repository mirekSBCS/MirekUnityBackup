using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_Gold : MonoBehaviour {

	public int points;
	public HUD_Manager HUD_Manager;
	public float JumpIncrease;
	public float SpeedIncrease;

	// Use this for initialization
	void Start () {
		HUD_Manager = GameObject.Find ("Player").GetComponent<HUD_Manager> ();
	}
	
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			gameObject.SetActive(false);
			HUD_Manager.UpdateScore(points);
			HUD_Manager.UpdateStats(JumpIncrease, SpeedIncrease);
		}
	}
}
