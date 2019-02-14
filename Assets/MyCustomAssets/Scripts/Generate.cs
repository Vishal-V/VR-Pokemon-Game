using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

	public GameObject[] monsters;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < Random.Range(500,560); i++) {
			monsterCount ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void monsterCount(){
		int index = Random.Range (0, monsters.Length);
		GameObject random = Instantiate (monsters [index]);
		//random.AddComponent(new Collider);
		random.transform.parent = transform;
		random.transform.localPosition = new Vector3 (Random.Range(-95,95), 0.5f, Random.Range(-95,95));
	}
}
