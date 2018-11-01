using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDScript : MonoBehaviour {

	float playerScore = 0;

	void Update() {
		playerScore += Time.deltaTime;
	}

	public void IncreaseScore(int amount){
		playerScore += amount;
	}

	void onDisable(){
		PlayerPrefs.SetInt("Score", (int)playerScore *100);
	}

	void OnGui(){
		GUI.Label(new Rect(10,10,100,300), "Score: " + (int)(playerScore *100));
	}
}
