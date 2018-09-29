using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathbyPlayer : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Deathable"))
        {
            Destroy(collision.gameObject);
        }
    }
}
