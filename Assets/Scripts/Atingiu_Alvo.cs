using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atingiu_Alvo : MonoBehaviour {

    public static int pontos = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bala(Clone)")
        {
            pontos = pontos + 1;

            Destroy(this.gameObject, 0.3f); //cubo
            Destroy(col.gameObject, 0.05f); //bala
        }
    }
}
