using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//para manipular carregamento de cenas/fases

public class GameManager : MonoBehaviour
{
    public int numeroDeBlocos;//contador de blocos
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){//se usuario apertou "ESC"
            ExitGame();
        }    
    }
    //metodo pra sair do jogo
    private void ExitGame(){
        Application.Quit();
    }

    //fazer com que contador aumente em 1 para cada bloco na fase Ou
    //diminuir numero de blocos quando destruido
    public void QuantidadeDeBlocos(char op){//publico para ser chamado no script "Tijolo"
        if( op.Equals('+')){
            numeroDeBlocos++;
        }else if(op.Equals('-') ){
            numeroDeBlocos--;
            //verifica se zerou blocos
            if(numeroDeBlocos <= 0){
                //verifica se existe proxima fase em relacao a atual
                if(SceneManager.GetActiveScene().buildIndex + 1
                 < SceneManager.sceneCountInBuildSettings){/*pega o indice de contagem
                 * da fase atual e acrescenta 1 (ficar igual a fase, ja que cena começa de
                 * indice 0 e fase de 1..
                 * verifica se o numero obtido é menor q qntdd de indices presentes em buildsettings*/
                    //carrega a proxima fase
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                 // se nao houver outra fase alem da atual
                else{
                    SceneManager.LoadScene(0); //volta a primeira fase
                }
            }
        }
    }
}
