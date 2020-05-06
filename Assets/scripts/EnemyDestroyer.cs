using UnityEngine;
using System.Collections;

public class EnemyDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D co1){
		if (co1.gameObject.tag == "Enemy Car") {
			Destroy (co1.gameObject);

		}
}
}
