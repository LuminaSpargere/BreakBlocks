using UnityEngine;
using UnityEngine.UI;

public class InfoPontuacao : MonoBehaviour
{
    public Text scores;//variavel que exibira o score
    public int pontos;//variavel para receber os nmr de blocos destruidos

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
		//seta o valor a variavel
        pontos = FindObjectOfType<GameManager>().blocosDestruidos;
		//passa o valor para a variavel que exibira na tela
        scores.text = "Scores: "+pontos.ToString();
    }
}
