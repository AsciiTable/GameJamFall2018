using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class user_interface : MonoBehaviour {

    public float hp = 10;
    public float currentHP = 4;
    public Image healthbar;
    //public movement player;

    public Gradient gradient;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (healthbar){
            float percentHealth = hp / currentHP;
            healthbar.fillAmount = percentHealth;
            healthbar.color = gradient.Evaluate(percentHealth);
        }
	}
}
