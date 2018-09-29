using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float move = 5f; 
    public float jump = 8f;
    public int jumpLimit = 2;
    int jumpCurrent = 0;
    public float multipleJumpForce = 4f;
    //float hor = .5f;
    public Rigidbody2D player;
    bool inAir;

    // Use this for initialization
    void Start () {
        inAir = false;
        player = GetComponent("Rigidbody2D") as Rigidbody2D;
	}
	
	// Update is called once per frame
	void Update () {
        //Horizontal Movement
        float hInput = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(hInput * move * Time.deltaTime, 0, 0);
        //float hor = Input.GetAxis("Horizontal");
       //transform.position = transform.position + new Vector3(hor * move * Time.deltaTime, 0, 0);

        //Jump
        if (Input.GetButtonDown("Jump") && inAir == false && jumpCurrent < jumpLimit)
        {
            //JumpDrag();
            jumpCurrent++;

            if (jumpCurrent == jumpLimit)
            {
                player.AddForce(new Vector2(0, (multipleJumpForce)), ForceMode2D.Impulse);
                inAir = true;
                Debug.Log("inAir set to true");
            }
            else 
            {
                player.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            }

        }

    }

    //Checks for collision on a platform to reset the jump bool
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Platform" && (inAir == true)){
            jumpCurrent = 0;
            inAir = false;
            Debug.Log("inAirset to false");
        }
    }

}
