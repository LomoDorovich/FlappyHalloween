using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreup : MonoBehaviour {

	private Text texto;
	private Text textoFinal;

	void Start (){
		texto = GameObject.Find ("TextoNivel").GetComponent<Text> ();
		textoFinal = GameObject.Find ("TextoFinal").GetComponent<Text> ();
	}
	void OnTriggerEnter2D(Collider2D col){
		GameControl.score = GameControl.score + 1;
		//Debug.Log (GameControl.score);

		texto.text = "Level " + GameControl.score.ToString ();
		textoFinal.text = texto.text;
	}
}
