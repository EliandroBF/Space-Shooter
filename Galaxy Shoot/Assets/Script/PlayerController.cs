using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Variavel de velocidade...
    private Rigidbody2D meuRB;
    [SerializeField] float velocidade = 10f;
    [SerializeField] private float velocidadeTiro = 2f;

    //Pegando meu objeto Tiro...
    [SerializeField] private GameObject meuTiro;
    //Variavel para pegar a posicao do meu tiro
    [SerializeField] private Transform posicaoTiro;
    //  Variavel Vida
    [SerializeField] private int vida = 5;
    [SerializeField] private GameObject explosao;
    

    // Start is called before the first frame update
    void Start()
    {
        meuRB = GetComponent<Rigidbody2D>();

        
        
    }

    // Update is called once per frame
    void Update()
    {
        Movendo();

        Atirando();
    }

    private void Movendo()
    {
        //Pegando o input vertical...
        float vertical = Input.GetAxis("Vertical");
        //Pegando o input orizontal...
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 minhaVelocidade = new Vector2(horizontal, vertical);
        //Metodo Normalize...
        minhaVelocidade.Normalize();

        //Passando a minha velocidade para o meu RB...
        meuRB.velocity = minhaVelocidade * velocidade;
    }

    private void    Atirando()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var tiro = Instantiate(meuTiro, posicaoTiro.position, transform.rotation);
            //Dar direção e velocidade para o RB do tiro
            tiro.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, velocidadeTiro);
        }
    }

    //Criar um método perde vida que recebe a quantidade de vida que ele deve perder (dano)
    public void PerdeVida(int dano)
    {
        //Perdendo a minha vida com base no dano
        vida -= dano;

        //Checando se eu morri
        if (vida <= 0)
        {
            Destroy(gameObject);
            //Criando um instatiate para criar a explosão
            Instantiate(explosao, transform.position, transform.rotation);
        }

        
    }

}
