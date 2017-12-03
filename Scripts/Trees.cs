using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour {

	public GameObject[] treeRock;

	// Use this for initialization
	void Start () {
		for (int j = 0; j < Random.Range(600,700); j++) {
			treeRockCount ();
		}
	}

	// Update is called once per frame
	void Update () {

	}

	void treeRockCount(){
		int index1 = Random.Range (0, treeRock.Length);
		GameObject random1 = Instantiate (treeRock [index1]);
		random1.transform.parent = transform;
		random1.transform.localPosition = new Vector3 (Random.Range(-99,99), 0.5f, Random.Range(-99,99));
	}
}
