﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //para reconhecer comandos de carregamento de cenas (para reiniciar jogo)

public class GameOver : MonoBehaviour
{	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //metodo para verificar colisões
    private void OnTriggerEnter2D(Collider2D outro){
        if(outro.gameObject.CompareTag("Bola")){//se objeto que colidiu tem tag "Bola"
            //chama game over
            SceneManager.LoadScene(5);
        }
    }
}
