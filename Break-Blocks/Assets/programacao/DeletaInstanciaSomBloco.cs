using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletaInstanciaSomBloco : MonoBehaviour
{
    public float timeParaDeletar; //tempo para deletar instancia de som do bloco destruido

    // Start is called before the first frame update
    void Start()
    {
        //destruir o gameObject (no caso instancia de som de destruir bloco)
        Destroy(this.gameObject, timeParaDeletar);//ira destruir o gameObject que tiver esse script  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
