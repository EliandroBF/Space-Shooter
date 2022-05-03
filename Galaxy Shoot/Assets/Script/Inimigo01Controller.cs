using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo01Controller : MonoBehaviour
{
    //Variavel para pegar meu Rigidbody2d
    private Rigidbody2D meuRB;

    //Velocidade do boss 1
    [SerializeField] private float velocidade = 3f;

    //Variavel para o meu tiro do inimigo
    public GameObject meuTiro;

    // Start is called before the first frame update
    void Start()
    {
        //Pegando meu Rigidbody2d
        meuRB = GetComponent<Rigidbody2D>();

        //Fazendo o inimigo descer
        meuRB.velocity = new Vector2(0f, -velocidade);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
