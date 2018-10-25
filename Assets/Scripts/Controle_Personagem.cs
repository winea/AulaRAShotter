using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//vamos fazer movimentaçao pelo mouse
public class Controle_Personagem : MonoBehaviour {

    public float velocidade = 10f;

	// Use this for initialization
	void Start () {
        //vamos desabilitar o mouse pro SO, so ira funcionar no game
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * velocidade;
        float straffe = Input.GetAxis("Horizontal") * velocidade;
        translation = translation * Time.deltaTime;
        straffe = straffe * Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
	}
}
