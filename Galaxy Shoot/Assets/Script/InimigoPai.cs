using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoPai : MonoBehaviour
{
    [SerializeField] protected float velocidade = 1f;
    [SerializeField] protected float velocidadeTiro = 3f;
    [SerializeField] protected int vida = 2;
    [SerializeField] protected GameObject explosao;
    [SerializeField] protected GameObject meuTiro;
    //Variavel para o meu tiro do inimigo...
    [SerializeField] protected float esperaTiro = 1f;
    [SerializeField] protected int pontos = 10;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerdeVida(int dano)
    {
        //Só vou rodar SE meu Y fou menor do que 5
        if (transform.position.y < 5)
        {
            //Perdendo vida com base no dano
            vida -= dano;

            //Checando se eu morri
            if (vida <= 0)
            {
                Destroy(gameObject);

                //Explosao criada quando o objeto for destruido
                Instantiate(explosao, transform.position, transform.rotation);

                //Ganhando pontos
                //controlador de inimigos
                var gerador = FindObjectOfType<GeradorInimigo>();
                gerador.DiminuiQuantidade();
                gerador.GanhaPontos(pontos);
            }
        }
    }

    
    //Se destruindo ao colidir com o destruidor
    private void OnTriggerEnter2D(Collider2D collision)
    {    
        
            if (collision.CompareTag("Destruidor"))
            {
                Destroy(gameObject);
                //controlador de inimigos
                var gerador = FindObjectOfType<GeradorInimigo>();
                gerador.DiminuiQuantidade();
            }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
            if (other.gameObject.CompareTag("Jogador"))
            {
                Destroy(gameObject);

                //controlador de inimigos
                var gerador = FindObjectOfType<GeradorInimigo>();
                gerador.DiminuiQuantidade();

                //Explosão inimigo
                Instantiate(explosao, transform.position, transform.rotation);

                //Tirando vida do player
                other.gameObject.GetComponent<PlayerController>().PerdeVida(1);
            }
        
    }

}
