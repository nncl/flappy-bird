using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flappy : MonoBehaviour {

	public float forcaImpulso;
	public static bool jogando;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		// Interface para o componente Rigidbody2D
		rb = GetComponent<Rigidbody2D> ();
		rb.gravityScale = 0.0f;

		jogando = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {

			if (!jogando) {
				rb.gravityScale = 1.0f;
				jogando = true;
			}

			rb.velocity = new Vector2(0.0f, 0.0f);
			rb.AddForce (Vector2.up * forcaImpulso);
		}

		// Rotação do personagem
		transform.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.y * 2.0f);
	}

	void OnTriggerEnter2D(Collider2D c) {
		Placar.pontos++;
	}

	// Colisão que finaliza o jogo
	void OnCollisionEnter2D(Collision2D c) {
		SceneManager.LoadScene ("start");
	}
}
