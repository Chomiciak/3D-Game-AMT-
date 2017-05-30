using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour {

	public int ammo;

	public Text text_ammo = null;

	// Use this for initialization
	void Start () {
		ammo = 25;
	}

	public ParticleSystem p = null;

	public GameObject odlamki = null; //prefab z odlamkami ktore pokazuja sie podczas strzelania

	int licznik = 0;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			if (licznik == 0) {

				if (ammo > 0) {

					licznik++;
					p.Play ();

					ammo = ammo - 1;
					text_ammo.text = "Ammo: " + ammo + "/25";


					GetComponent<AudioSource> ().Play ();

					RaycastHit hit;
					if (Physics.Raycast (
						    Camera.main.ScreenPointToRay (Input.mousePosition), 
						    out hit
					    )) {
						hit.collider.GetComponent<Renderer> ().material.color = Color.red;
				
						hit.collider.GetComponent<AudioSource> ().Play ();

						hit.rigidbody.AddForceAtPosition (-100 * transform.forward, hit.point);

						GameObject o = Instantiate (odlamki);
						o.transform.position = hit.point;
						o.GetComponent<ParticleSystem> ().Play ();


					}
				} else {
					Debug.Log ("Brak amunicji!");
				}

			} else {
				licznik++;
				if (licznik == 10) {
					licznik = 0;
				}
			}
		}
	}



}
