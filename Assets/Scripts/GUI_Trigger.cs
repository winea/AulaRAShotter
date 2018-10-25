using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_Trigger : MonoBehaviour {

    public static int score;

	// Use this for initialization
	void Start () {
        this.GetComponent<Text>().text = "Bem Vindo. \nAtinja Todos os Blocos";
	}
	
	// Update is called once per frame
	void Update () {
        score = Atingiu_Alvo.pontos;

        if (score >= 10)
        {
            this.GetComponent<Text>().text = ("Parabéns,\n Voce Ganhou!");

        }
        else
        {
            this.GetComponent<Text>().text= ("Blocos\nAtingidos = " + score);
        }
	}
}
