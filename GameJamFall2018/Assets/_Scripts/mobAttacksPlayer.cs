using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//put this to obstacles that attacks player

public class mobAttacksPlayer: MonoBehaviour
{

    public float maxHP = 20f;
    public float currentHP = 20f;
    public float KnockbackForce = 10f;

    private Vector2 direction;

    private void OnCollisionEnter2D(Collision2D collision) {

        movement script_movement = collision.gameObject.GetComponent<movement>();

        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


    }
}
