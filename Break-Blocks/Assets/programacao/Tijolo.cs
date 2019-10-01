using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tijolo : MonoBehaviour
{
	public GameObject SomDoBloco; //ja que transformamos o som em gameObject
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag ("Bola");
		/*Cada tijolo tem esse presente script, então cada vez que esse script
		 * iniciado numa fase quer dizer que há um tijolo..
		*/
		//procura o objeto Script pelo nome, e ja aciona seu metodo
		FindObjectOfType<GameManager>().QuantidadeDeBlocos('+');
    }

    // Update is called once per frame
    void Update()
    {
    }
	

	//reaproveitei o metodo de detectar colisao e ja coloquei reproducao de som nele 
		//..
	/*fazendo com que o tijolo saida quando algo encostar nele, usando metodo pronto*/	
	private void OnCollisionEnter2D(Collision2D outro){//variavel para obter informacao de colisao
        //verificando se foi a bola que colidiu com tijolo (usando sistema de tags disponivel no inspector)
		if(outro.gameObject.CompareTag("Bola")){ //verifica se o que chocou com tijolo é a bola ( "Bola" refere se a tag dada a bola no inspector)
			Instantiate(SomDoBloco, transform.position, transform.rotation); //instancia o som o som na posicao fisica em que
			//o gameobject do script esta.. (no caso, refere se aos blocos);

			//aCHA O SCRIPT E CHAMA O METODO DIMINUINDO QUANTIDADE
			FindObjectOfType<GameManager>().QuantidadeDeBlocos('-');	
			Destroy(this.gameObject);//destroi o tijolo chocado
		}
	}

}
