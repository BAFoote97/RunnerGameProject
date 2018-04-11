using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

	public GameObject WallPrefab;

	public float SpawnDelay = 1f;

	public Vector3 MoveSpeed;

	// Use this for initialization
	void Start () {

		StartCoroutine (SpawnWall ());
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	IEnumerator SpawnWall()
	{
		Instantiate (WallPrefab, transform.position, Quaternion.identity);

		yield return new WaitForSeconds (SpawnDelay);

		StartCoroutine (SpawnWall ());

	}



}
