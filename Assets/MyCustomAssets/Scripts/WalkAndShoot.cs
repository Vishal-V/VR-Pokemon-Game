using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAndShoot : MonoBehaviour {
	public GameObject pokeball;
	public float speed = 10;
	public float speed1 = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = transform.position + Camera.main.transform.forward * speed1 * Time.deltaTime;

		if (Input.GetButtonDown ("Fire1")) {
			GameObject pokeGo = Instantiate (pokeball);
			pokeGo.transform.position = transform.position;	
			Rigidbody rb = pokeGo.GetComponent<Rigidbody> ();
			Camera cam = GetComponentInChildren<Camera> ();

			rb.velocity = cam.transform.rotation * Vector3.forward * speed;
		}
	}
}
