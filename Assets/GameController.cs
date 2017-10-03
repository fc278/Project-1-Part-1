using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	float time; //decimal points
	int myScore; //integers/whole numbers
	bool printedMessage = false; //true or false conditions

	// Use this for initialization
	void Start () {
		print ("The game has begun!");

		printedMessage = false;
	}
	
	// Update is called once per frame
	void Update () {

	//Amount of time that has elapsed in the game
		if (Time.time > 3 && printedMessage == false) {
			//stuff that happens if true
			print ("It has been three seconds!");
			printedMessage = true;
		}
	}
}
