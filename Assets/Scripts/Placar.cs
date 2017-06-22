using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // manually added

public class Placar : MonoBehaviour {

	public static int pontos;
	public Text txtPontos;

	// Update is called once per frame
	void Update () {
		if (!Flappy.jogando) {
			pontos = 0;
		}

		txtPontos.text = pontos.ToString();
	}
}
