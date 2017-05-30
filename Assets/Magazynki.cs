using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazynki : MonoBehaviour {

	public Shooting s;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	int iloscAmunicji = 25;

	void OnTriggerEnter (Collider c){
		if (c.name.StartsWith ("ammo")) {
			int a = s.ammo; 
			s.ammo = a + iloscAmunicji;
			s.text_ammo.text = "Ammo: " + s.ammo + "/25";
			Destroy (c.gameObject);
		}
	}
}
