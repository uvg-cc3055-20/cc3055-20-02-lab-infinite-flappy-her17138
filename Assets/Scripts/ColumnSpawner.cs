﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour {
	public float spawnTime = 4f;
	public float elapsedTime = 0f;
	public GameObject column;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameController.instance.gameOver == false) {
				
			if (elapsedTime < spawnTime) {
				elapsedTime += Time.deltaTime;
			} else {
				float random = Random.Range (-2f, 2f);
				Instantiate (column, new Vector3 (8, random, 0), Quaternion.identity);
				elapsedTime = 0f;	
			}
		}
	}
}
