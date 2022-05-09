using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorInimigo : MonoBehaviour
{
    //Criando inimigos
    [SerializeField] private GameObject[] inimigos;
    private int pontos = 0;
    [SerializeField] private int level = 1;

    private float esperaInimigo = 0f;
    [SerializeField] private float tempoEspera = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GeraInimigos();
    }

    private void GeraInimigos()
    {
        //Diminuindo o tempo SE ele for maior do que 0
        if (esperaInimigo > 0)
        {
            esperaInimigo -= Time.deltaTime;
        }

        //Checando SE a espera já zerou
        if (esperaInimigo <= 0f)
        {
            int quantidade = level * 4;
            int qtdInimigo = 0;

            //Criando vários inimigos de uma vez...
            while(qtdInimigo < quantidade)
            {

                GameObject inimigoCriado;

                //Decidindo qual inimigo vai ser criado com base no level
                float chance = Random.Range(0f, level);
                if (chance > 2f)
                {
                    inimigoCriado = inimigos[1];
                }
                else
                {
                    inimigoCriado = inimigos[0];
                }

                //Criando o inimigo em posições aleatórias
                Vector3 posicao = new Vector3(Random.Range(-8f, 8f), Random.Range(6f, 12f), 0f);

                //Criando o inimigo...
                Instantiate(inimigoCriado, posicao, transform.rotation);
                qtdInimigo++;

                //Reiniciando a espera...
                esperaInimigo = tempoEspera;
            }    
        }
    }
}
