using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathtobyPlayer : MonoBehaviour {

    void OnCollisionEnter (Collision death)
    {
        if (death.gameObject.tag == "Player")
        {
            Destroy(death.gameObject);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame 
	void Update () {
		
	}
}
