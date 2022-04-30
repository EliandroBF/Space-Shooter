using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Variavel de velocidade
    private Rigidbody2D meuRB;
    [SerializeField] float velocidade = 10f;

    // Start is called before the first frame update
    void Start()
    {
        meuRB = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
        //Pegando o input vertical
        float vertical = Input.GetAxis("Vertical");
        //Pegando o input orizontal
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 minhaVelocidade = new Vector2(horizontal, vertical);
        //Metodo Normalize
        minhaVelocidade.Normalize();

        //Passando a minha velocidade para o meu RB
        meuRB.velocity = minhaVelocidade * velocidade;  
        

        
        

    }
}