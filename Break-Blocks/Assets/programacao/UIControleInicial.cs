using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIControleInicial : MonoBehaviour
{
    //botoes publicos para adicionar nesses campos, o Buttons criados em UI
    public Button BotaoPlay;
    public Button BotaoQuit;
    public Button BotaoTutorial;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    //Metodo para qnd der play
   public  void Play(){
        SceneManager.LoadScene(1); // primeira fase
    }

    public void Quit(){
        Application.Quit();
    }
    public void Tutorial(){
        SceneManager.LoadScene(6); // tutorial
    }
    
}
