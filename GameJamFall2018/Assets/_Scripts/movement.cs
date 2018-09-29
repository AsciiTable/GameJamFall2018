using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float move = 5f; 
    public float jump = 8f;
    float hor = .5f;
    public Rigidbody2D myRigidBody;
    bool inAir;

    // Use this for initialization
    void Start () {
        inAir = false;
	}
	
	// Update is called once per frame
	void Update () {
        float hInput = Input.GetAxis("Horizontal");//horizontal input from the user
        //float vInput = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(hInput * move * Time.deltaTime, 0, 0);
        float hor = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(hor * move * Time.deltaTime, 0, 0);
        if (Input.GetButtonDown("Jump") && inAir == false)
        {
            myRigidBody.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            inAir = true;
            Debug.Log("inAir set to true");
        }

    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Platform" && (inAir == true)){
            inAir = false;
            Debug.Log("inAirset to false");
        }
    }
}
