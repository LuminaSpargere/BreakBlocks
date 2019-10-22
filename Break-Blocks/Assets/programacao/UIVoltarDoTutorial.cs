using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class UIVoltarDoTutorial : MonoBehaviour
{
    public Button voltar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Voltar(){
        SceneManager.LoadScene(0); //menu inicial
    }
}
