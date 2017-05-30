using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour {

	 public  void wlaczGre(){
		Application.LoadLevel ("ccc");
	}
	 
	public void wylaczGre(){
		Application.Quit ();
	}
}
