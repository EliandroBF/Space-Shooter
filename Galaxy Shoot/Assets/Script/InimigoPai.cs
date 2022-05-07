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
        //Perdendo vida com base no dano
        vida -= dano;

        //Checando se eu morri
        if (vida <= 0)
        {
            Destroy(gameObject);

            //Explosao criada quando o objeto for destruido
            Instantiate(explosao, transform.position, transform.rotation);
        }
    }
}
