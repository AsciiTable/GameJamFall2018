﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//put this to obstacles that attacks player

public class mobAttacksPlayer: MonoBehaviour
{

    public float currentHP = 20f;
    public float KnockbackForce = 10f;

    private Vector2 direction;

    private void OnCollisionEnter2D(Collision2D collision) {

        movement script_movement = collision.gameObject.GetComponent<movement>();

        if (collision.gameObject.CompareTag("Player"))
        {
           if(script_movement != null)
            {
                currentHP = currentHP - 1f;

                if (transform.position.x < script_movement.transform.position.x)
                {
                    direction = Vector2.right + Vector2.up;
                }
                else if (transform.position.x > script_movement.transform.position.x)
                {
                    direction = Vector2.right + Vector2.up;
                }

                Vector2 forceVector = direction * KnockbackForce;

                //movement.IsKnockBack(forceVector);
            }
            
        }


    }
}