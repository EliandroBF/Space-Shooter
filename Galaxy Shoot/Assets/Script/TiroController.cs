using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroController : MonoBehaviour
{
    //Variavel Rigidbody...
    private Rigidbody2D meuRB;
    [SerializeField] private float vel = 10f;
    
    
    
    

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
        Destroy(gameObject);
    }

}
