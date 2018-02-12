using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombLitCountDown : MonoBehaviour {

    public GameObject explosion;

	// Use this for initialization
	void Start () {
        Invoke("Explode", 3);
	}
	
	void Explode()
    {
        // create explosion at this point
        Debug.Log("boom");
    }
}
