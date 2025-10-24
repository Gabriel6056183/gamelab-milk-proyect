using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public float moveSpeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
{
    Vector2 pos = transform.position;

    pos.y += moveSpeed * Time.fixedDeltaTime;

    // Si llega al límite superior, cambia dirección hacia abajo
    if (pos.y >= 3.5f)
    {
        moveSpeed = -Mathf.Abs(moveSpeed);
    }
    // Si llega al límite inferior, cambia dirección hacia arriba
    else if (pos.y <= -3.5f)
    {
        moveSpeed = Mathf.Abs(moveSpeed);
    }

        transform.position = pos;
}
        

    }
