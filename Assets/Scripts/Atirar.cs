﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Atirar : MonoBehaviour {

    public Rigidbody bullet;
    private float velocidade = 1300;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //criar as balas que sao prefabs
		if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instance = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            instance.AddForce(forward * velocidade);

            Destroy(instance.gameObject, 2.5f);
        }

        //reinicia o jogo qdo aperta essa tecla
        if (Input.GetKey("p"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
