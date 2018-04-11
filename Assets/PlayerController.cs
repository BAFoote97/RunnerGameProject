using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D Player;

	public float JumpForce;
	public int JumpForceInt;

	public Animator Anim;

	public GameObject GameOverText;

	// Use this for initialization
	void Start () {

		Player = gameObject.GetComponent<Rigidbody2D> ();

		Player.mass = 1;
		//Player.AddForce (Vector2.up * JumpForce, ForceMode2D.Impulse);

	}

	void UpdatePlayerPosition (Vector3 position) {



	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Player.AddForce (Vector2.up * JumpForce, ForceMode2D.Impulse);
		}
		
	}
}
