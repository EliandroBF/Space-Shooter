using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosãoController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Destruindo o efeito de fumaça do inpacto do tiro
    public void Morrendo()
    {
        Destroy(gameObject);
    }
}
