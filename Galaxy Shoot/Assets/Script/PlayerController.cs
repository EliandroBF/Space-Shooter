using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Variavel de velocidade
    public float vel = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
        //Escrevendo uma variavel com var para pegar o movimento para a horizontal
        var horizontal = Input.GetAxis("Horizontal") * vel;
        Debug.Log(horizontal);


    }
}
