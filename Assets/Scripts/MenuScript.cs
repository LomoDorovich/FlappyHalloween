using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	
	Animator animacion_panel;
	
	
	
	// Use this for initialization
	void Start () {
		animacion_panel = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControl.dead) {
			animacion_panel.SetBool ("Mostrar", true);
		}
		
		
	}
	
	public void restart(){
		GameControl.dead = false;
		GameControl.score = 0;
		animacion_panel.SetBool ("Mostrar", false);
		Application.LoadLevel (Application.loadedLevel);
	}
	
	public void quit (){
		Application.Quit ();
	}
	
	
}