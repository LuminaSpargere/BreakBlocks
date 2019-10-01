using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{

	public float velocidadeDaBarra; //public faz com que a unity enxergue a variavel
	
	//variaveis de controle de limite da barra (para que não saia para os lados), as quais recebem valor dentro da unity
	//tais valores obtidos arrastando o objeto no limite max do ambiente..(position x) na unity
	public float limiteMinimoHorizontal, limiteMaximoHorizontal; //minimo refere a esquerda, maximo a direita
    
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()//metodo chamado constantemente, 1 vez por frame
    {
        MovimentoBarra();
    }
	
	private void MovimentoBarra(){
		/*informando a unity qual componente ela ira limitar em x - limitacao 
			*é feita por: Mathf.Clamp(transform.position.x, limiteMinimoHorizontal, limiteMaximoHorizontal)
			*transform manipula o transform do objeto na unyt
			* transform.position.y limita movimento pra y,impedindo ir pra cima/baixo  
		*/
		transform.position = new Vector2( Mathf.Clamp(transform.position.x, limiteMinimoHorizontal, limiteMaximoHorizontal),
		transform.position.y); 
		
		//movimentacao direita
		if(Input.GetAxisRaw("Horizontal") > 0.01f){//Se houver movimento horizontal no eixo  positivo
			transform.Translate(Vector2.right * velocidadeDaBarra * Time.deltaTime);/*transform acessa componete trasform do game object, 
			* translate modifica valor dos eixos x,y,z do mesmo, e vector 2 acessa eixos x e y.. tudo isso para movimentar a direita
			* Time.deltaTime tem objetivo de deixar velocidade igual para todos os PC´s, independente de sua capacidade */
		}
		//movimentacao esquerda
		if(Input.GetAxisRaw("Horizontal") < -0.01f){ //verifica se eixo negativo acionado
			transform.Translate(Vector2.left * velocidadeDaBarra * Time.deltaTime);
		}
	}
}
