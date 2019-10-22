using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InfoFaseAtual : MonoBehaviour
{
    public Text level;//variavel a ser exibida na tela
    public int faseAtual; //variavel para receber a fase corrente
    // Start is called before the first frame update
    void Start()
    {
		//passa a fase atual para a variavel
        faseAtual = SceneManager.GetActiveScene().buildIndex;
		//passa informacao para variavel que exibira na tela
        level.text =  "Level: "+ faseAtual;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
