using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;

    public float speed; //Velocidade da Movimentação

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime faz com que o player se movimente na mesma velocidade em qualquer computador independente da RAM
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime); // faz o player se movimentar de forma mais natural
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement); // aumentar a posição no eixo Y pq queremos que ele se movimente para cima            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement); // diminuir a posição no eixo y pq queremos que ele se movimente para baixo            
        }

        
    }
}
