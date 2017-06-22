using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cano : MonoBehaviour {

	public float velocidade;
	public float limiteSuperiorY, limiteInferiorY;
	float limiteX;

	Vector3 posicao;

	void Start() {
		// Pega a pos inicial do cano para usar como retorno
		posicao = transform.position;
		limiteX = posicao.x * -1;
	}

	// Update is called once per frame
	void Update () {

		if (Flappy.jogando) {
			// Move o cano
			transform.Translate(Vector2.left * velocidade * Time.deltaTime);

			// Verifica limite para retornar
			if (transform.position.x <= limiteX) {
				transform.position = new Vector3 (
					posicao.x,
					Random.Range (limiteInferiorY, limiteSuperiorY),
					posicao.z);
			}
		}

	}
}
