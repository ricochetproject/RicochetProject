﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;



	public float fireRate = 0.5F;
	
	private float nextFire = 0.0F;




	void Update()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			GameObject clone = Instantiate(shot, shotSpawn.position, shotSpawn.rotation) as GameObject;
			GetComponent<AudioSource>().Play();
		}



	}
}
