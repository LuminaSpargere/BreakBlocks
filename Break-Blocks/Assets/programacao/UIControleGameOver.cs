using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIControleGameOver : MonoBehaviour
{
    //botoes publicos para adicionar nesses campos, o Buttons criados em UI
    public Button BotaoRestart;
    public Button BotaoQuit;
    public AudioSource somGameOver;
    // Start is called before the first frame update
    void Start()
    {
        somGameOver.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Metodo para qnd der restart
    public void Restart(){
        SceneManager.LoadScene(1); // primeira fase
    }

    public void Quit(){
         Application.Quit();
    }
}
