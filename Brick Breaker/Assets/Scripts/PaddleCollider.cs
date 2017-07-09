using UnityEngine;
using System.Collections;

public class PaddleCollider : MonoBehaviour {
	public LevelManager levelManager;
	// On collision w/ trigger
	void OnTriggerEnter2D(Collider2D collider)	{
		print ("trigger");
		levelManager.LoadLevel("Lose");
	}

	void OnCollisionEnter2D(Collision2D collision)	{
		print ("Collision");
		//levelManager.LoadLevel("Win");
	}
}
