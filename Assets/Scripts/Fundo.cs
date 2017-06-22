using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundo : MonoBehaviour {

	public float limiteX;
	public float posicaoX;
	public float velocidade;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Movimenta o fundo p esquerda
		transform.Translate (Vector2.left * velocidade * Time.deltaTime);

		// Reposiciona o fundo para ficar em looping
		if (transform.position.x <= limiteX) {
			transform.position = new Vector3 (posicaoX, 0.0f, 0.0f);
		}
	}
}
