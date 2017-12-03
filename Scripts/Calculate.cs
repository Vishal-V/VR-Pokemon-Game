using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour {
	public int count;
	// Use this for initialization
	void Start () {
		count = 0;
	}

	public void counterValue(){
		count = count + 1;
		Debug.Log ("Count: " + count);
	}

}
