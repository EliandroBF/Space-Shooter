using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo01Controller : InimigoPai
{
    //Variavel para pegar meu Rigidbody2d...
    private Rigidbody2D meuRB;

     
    // Variavei para pegar a posicao do tiro
    [SerializeField] private Transform posicaoTiro;

    
    

    // Start is called before the first frame update
    void Start()
    {
        //Pegando meu Rigidbody2d...
        meuRB = GetComponent<Rigidbody2D>();

        //Fazendo o inimigo descer...
        meuRB.velocity = new Vector2(0f, velocidade );
        
        //Deixando a espera aleatoria para o primeiro tiro
        esperaTiro = Random.Range(0.5f, 2f);
       
    }

    // Update is called once per frame
    void Update()
    {
        Atirando();

        

    }

    private void Atirando()
    {
        //Vou checar se o meu sprite rederer está vísivel
        //Pegando informações dos meus filhos
        bool visivel = GetComponentInChildren<SpriteRenderer>().isVisible;


        //Diminuir a espera, e se ela for menor igual a zero então eu atiro...
        esperaTiro -= Time.deltaTime;
        if (esperaTiro <= 0 && visivel == true)
        {
            //Instaciando o tiro do inimigo...
            var tiro = Instantiate(meuTiro, posicaoTiro.position, transform.rotation);

            //Dar direção e velocidade para o RB do tiro
            tiro.GetComponent<Rigidbody2D>().velocity = Vector2.down * velocidadeTiro;

            esperaTiro = Random.Range(1.5f, 2f);

        }        
    }

}
