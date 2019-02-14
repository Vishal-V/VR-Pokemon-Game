using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collected : MonoBehaviour {
	Calculate calc;
	// Use this for initialization
	void Start () {
		calc = FindObjectOfType<Calculate> ();
	}

		public void onTriggerEnter(Collider collided){
			if(collided.gameObject.CompareTag("redmon")){
				Destroy (collided.gameObject);
				calc.counterValue ();
			}

			if(collided.gameObject.CompareTag("peachmon")){
				Destroy (collided.gameObject);
				calc.counterValue ();
			}

			if(collided.gameObject.CompareTag("violetmon")){
				Destroy (collided.gameObject);
				calc.counterValue ();
			}
		}

		void onCollisionEnter(Collision col){
		
			if (col.gameObject.CompareTag ("base")) {
				Destroy (this.gameObject);
			}
		}
		
	void update() {

	}
}
