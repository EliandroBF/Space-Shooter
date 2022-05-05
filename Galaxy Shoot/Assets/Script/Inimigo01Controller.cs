using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo01Controller : MonoBehaviour
{
    //Variavel para pegar meu Rigidbody2d...
    private Rigidbody2D meuRB;

    //Velocidade do boss 1...
    [SerializeField] private float velocidade = 3f;

    //Variavel para o meu tiro do inimigo...
    [SerializeField] private GameObject meuTiro;
    private float esperaTiro = 1f; 
    // Variavei para pegar a posicao do tiro
    [SerializeField] private Transform posicaoTiro;

    //Vida 
    [SerializeField] private int vida = 1;

    // Start is called before the first frame update
    void Start()
    {
        //Pegando meu Rigidbody2d...
        meuRB = GetComponent<Rigidbody2D>();

        //Fazendo o inimigo descer...
        meuRB.velocity = new Vector2(0f, -velocidade );
        
        //Deixando a espera aleatoria para o primeiro tiro
        esperaTiro = Random.Range(0.5f, 2f);
       
    }

    // Update is called once per frame
    void Update()
    {
        //Vou checar se o meu sprite rederer está vísivel
        //Pegando informações dos meus filhos
        bool visivel = GetComponentInChildren<SpriteRenderer>().isVisible;
        
        
        

        //Diminuir a espera, e se ela for menor igual a zero então eu atiro...
        esperaTiro -= Time.deltaTime;
        if (esperaTiro <= 0 && visivel == true)
        {
            //Instaciando o tiro do inimigo...
            Instantiate(meuTiro, posicaoTiro.position, transform.rotation);

            esperaTiro = Random.Range(1.5f, 2f);
            
        }


    }

    //Criar um método perde vida que recebe a quantidade de vida que ele deve perder (dano)
    public void PerdeVida(int dano)
    {
        //Perdendo a minha vida com base no dano
        vida -= dano;

        
        Debug.Log("buuuuu!!!!!2");
    }
}
