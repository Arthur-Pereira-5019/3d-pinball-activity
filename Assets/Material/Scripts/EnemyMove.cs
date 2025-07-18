﻿using System;
using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	public float moveSpeed = 5f;		// enemy move speed
	public GameObject target;
	private Transform targetPos;

	void Awake() {
		if(target == null) {
			targetPos = GameObject.Find("Player").transform;
		}else{
			targetPos = GameObject.Find("Player").transform;
		}
	}
	
	void EnemyMovement() {
		if(Vector3.Distance(transform.position, targetPos.position) > 0.7 && Vector3.Distance(transform.position, targetPos.position) < 120) {
			transform.position = Vector3.MoveTowards(transform.position, targetPos.position, moveSpeed * Time.deltaTime);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GameManager.gm.timeFlow == false) {
			EnemyMovement();
		}
	}
}