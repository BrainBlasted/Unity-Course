using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	int max;
	int min;
	int guess;
	public int max_guesses = 15;
	public Text text;


	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Is the number higher, lower, or equal to " + guess + "?";
	}
	

	void StartGame () {
		max = 1000;
		min = 1;
		guess = Random.Range(max, min);

		max = max + 1;
	}

	public void higher(){
		Debug.Log("The number was higher than " + guess + ".");
		min = guess;
		NextGuess();
	}

	public void NextGuess() {
		guess = Random.Range(max-1, min+1);
		max_guesses = (max_guesses - 1);
		if (max_guesses <= 0){
			Application.LoadLevel("Lose");
		}
	}

	public void lower(){
		Debug.Log("The number was lower than " + guess + ".");
		max = guess;
		NextGuess();
	}

	public void equal(){
		Debug.Log("The number was equal to " + guess + ".");
	}
}
