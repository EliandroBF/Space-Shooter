using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo02Controller : InimigoPai
{
    //Variavel para pegar meu Rigidbody
    private Rigidbody2D meuRB;
    


    // Start is called before the first frame update
    void Start()
    {
        //Pegando meu Rigidbody
        meuRB = GetComponent<Rigidbody2D>();

        //Fazendo o inimigo ir para os lados
        meuRB.velocity = Vector2.up * velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
