using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class user_interface : MonoBehaviour {

    public float hp = 10;
    public mobAttacksPlayer script_mobAttacksPlayer;
    public Image healthbar;
    //public movement player;

    public Gradient gradient;

	// Use this for initialization
	void Start () {
        script_mobAttacksPlayer = GetComponent<mobAttacksPlayer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (healthbar){
            float percentHealth = script_mobAttacksPlayer.currentHP / script_mobAttacksPlayer.currentHP;
            healthbar.fillAmount = percentHealth;
            healthbar.color = gradient.Evaluate(percentHealth);
        }
	}
}
