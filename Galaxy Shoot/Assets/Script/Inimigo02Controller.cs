using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo02Controller : InimigoPai
{
    //Variavel para pegar meu Rigidbody
    private Rigidbody2D meuRB;
    [SerializeField] private GameObject meuTiro;
    [SerializeField] private float esperaTiro = 1f;
    


    // Start is called before the first frame update
    void Start()
    {
        //Pegando meu Rigidbody
        meuRB = GetComponent<Rigidbody2D>();

        //Fazendo o inimigo ir para os lados
        meuRB.velocity = Vector2.up * velocidade;

        //Fazendo o primeiro tiro do inimigo sair mais rapido
        esperaTiro = Random.Range(0.5f, 1.8f);
    }

    // Update is called once per frame
    void Update()
    {
        //Vou checar se o meu sprite rederer está vísivel
        //Pegando informações dos meus filhos
        bool visivel = GetComponentInChildren<SpriteRenderer>().isVisible;


        esperaTiro -= Time.deltaTime;
        if (esperaTiro <= 0 && visivel == true)
        {
            //Instanciando meu tiro
            Instantiate(meuTiro, transform.position, transform.rotation);

            esperaTiro = Random.Range(1.5f, 2f);
        }
    }
}
