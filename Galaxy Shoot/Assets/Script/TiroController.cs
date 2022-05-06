using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TiroController : MonoBehaviour
{
    //Variavel Rigidbody...
    private Rigidbody2D meuRB;
    [SerializeField] private float vel = 10f;
      
    [SerializeField] private GameObject fumacaTiro;
    
    

    // Start is called before the first frame update
    void Start()
    {
        //Pegando meu Rigidbody...
        meuRB = GetComponent<Rigidbody2D>();

        //Tiro Indo para cima...
        meuRB.velocity = new Vector2(0f, vel);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Destruindo o tiro do player...
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Pegar o método perde vida e aplicar nele o dano (other)
        if (collision.CompareTag("Inimigo"))
        {
            //Isso só deve rodar se ele colidiu com alguem que tem o script inimigo 01 controller 
            collision.GetComponent<InimigoPai>().PerdeVida(1);

            //Tentando Colocar a animaçao de tiro
            Instantiate(fumacaTiro, transform.position, transform.rotation);
        }
        
        if (collision.CompareTag("Jogador"))
        {
            //Isso só deve rodar se ele colidiu com alguem que tem o script player controller 
            collision.GetComponent<PlayerController>().PerdeVida(1);
            
            //Tentando Colocar a animaçao de tiro
            Instantiate(fumacaTiro, transform.position, transform.rotation);
        }
        
        Destroy(gameObject);
    }

}
