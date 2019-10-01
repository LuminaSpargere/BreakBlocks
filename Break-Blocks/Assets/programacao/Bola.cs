using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
	/* fazendo com que a bola comece de caindo e nao de cima (encostada) da barra
		*fazendo com que jogo so comece quando tecla for apertada
	*/

	public bool deuStart; // variavel pra saber se usuario deu start

	// variaveis para evitar que bolinha fique em loop
	public float DirecaoAleatoriaX, DirecaoAleatoriaY;
	
	// pra saber definir direcao inicial da bola (fazer com que não suba completamente reta)
	public float direcaoHorizontal, direcaoVertical;
	
	public Rigidbody2D varRigidbody2D;//para colocar velocidade inicial na bola
	
	public AudioSource SomDaBola;
	
    // Start is called before the first frame update
    void Start()
    {
        deuStart = false; //seta como falso para esperar usuario iniciar jogo
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){//verifica se ENTER foi pressionado (deu start)
			LancarBola();
		}
    }
	
	//metodo para lancar a bola
	private void LancarBola(){
		if(deuStart == false){//se não comecou
            varRigidbody2D.velocity = new Vector2(direcaoHorizontal, direcaoVertical); //lance para cima com veelocidade..
			deuStart = true;// starta o jogo ja que a bola foi lancada
		}
	}
	
	//metodo pra tocar som da bola quando houver colisao da mesma
	private void OnCollisionEnter2D(Collision2D outro){
		SomDaBola.Play();
		//ao se chocar com algo, muda a velocidade, assim n fica em loop
		varRigidbody2D.velocity += new Vector2(DirecaoAleatoriaX, DirecaoAleatoriaY); 
	}
}
