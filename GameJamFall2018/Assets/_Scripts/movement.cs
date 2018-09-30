using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    [SerializeField]
    private Transform m_GroundCheck;
    public float k_GroundedRadius = .2f;
    [SerializeField] private LayerMask m_WhatIsGround;
    //private bool m_Grounded;

    public float move = 5f; 
    public float jump = 8f;
    public int jumpLimit = 2;
    [SerializeField] int jumpCurrent = 0;
    public float multipleJumpForce = 4f;
    //float hor = .5f;
    public Rigidbody2D player;
    public bool onGround;

    public bool IsKnockedBack = false;

    // Use this for initialization
    private void Awake () {
       //m_GroundCheck = transform.Find("GroundCheck");
        onGround = true;
        player = GetComponent("Rigidbody2D") as Rigidbody2D;
	}
	
	// Update is called once per frame
	void Update () {



    }

    private void FixedUpdate()//????
    {
        onGround = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                onGround = true;
                jumpCurrent = 0;
            }
        }
        //Knockback stuff?
        if (IsKnockedBack) return;

        //Horizontal Movement
        float hInput = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(hInput * move * Time.deltaTime, 0, 0);

        //Jump
        //Debug.Log("Before first if: " + jumpCurrent);
        if ((Input.GetButtonDown("Jump") && (onGround == true)))
        {
            player.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            onGround = false;
            jumpCurrent++;
            //Debug.Log("After first if: " + jumpCurrent);
            if ((Input.GetButtonDown("Jump") && jumpCurrent < jumpLimit))
            {
                player.AddForce(new Vector2(0, multipleJumpForce), ForceMode2D.Impulse);
            }

        }
        //Debug.Log("After first if: " + jumpCurrent);

        //Debug.Log("After second if: " + jumpCurrent);

    }


    public void IsKnockBack(Vector2 knockbackforce)
    {
        IsKnockedBack = false;
    }

}
