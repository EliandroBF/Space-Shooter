using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo02Controller : InimigoPai
{
    //Variavel para pegar meu Rigidbody
    private Rigidbody2D meuRB;
    
    [SerializeField] private Transform posicaoTiro;
    


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
        Atirando();
    }

    private void    Atirando()
    {
        //Vou checar se o meu sprite rederer está vísivel
        //Pegando informações dos meus filhos
        bool visivel = GetComponentInChildren<SpriteRenderer>().isVisible;

        if (visivel)
        {
            //Encontrando o player na cena
            var player = FindObjectOfType<PlayerController>();

            //Só vai acontecer SE o player existir
            if (player)
            {

                esperaTiro -= Time.deltaTime;
                if (esperaTiro <= 0 && visivel == true)
                {
                    //Instanciando meu tiro
                    var tiro = Instantiate(meuTiro, posicaoTiro.position, transform.rotation);
                    
                    //Encontrando o valor da direção do player
                    Vector2 direcao = player.transform.position - tiro.transform.position;
                    //Normalizando a velocidade dele
                    direcao.Normalize();
                    //Dando a direção do meu tiro
                    tiro.GetComponent<Rigidbody2D>().velocity = direcao * velocidadeTiro;

                    //Dando o angulo que o tiro tem que estar
                    float angulo = Mathf.Atan2(direcao.y, direcao.x) * Mathf.Rad2Deg;
                    //Passando o angulo
                    tiro.transform.rotation = Quaternion.Euler(0f, 0f, angulo + 90f);

                    esperaTiro = Random.Range(1.5f, 3f);
                }
            }
        }
    }
}
