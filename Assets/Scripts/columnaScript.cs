﻿using UnityEngine;
using System.Collections;

public class columnaScript : MonoBehaviour {
	public int vhorizontal = -3;
	Vector3 movimiento;
	

	void Update () {
		movimiento = new Vector3 (vhorizontal, 0, 0);
		transform.Translate (movimiento * Time.deltaTime);
	}
}
