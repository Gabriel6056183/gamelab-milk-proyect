using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightLeft : MonoBehaviour
{

    public float moveSpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("colision");
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos.x -= moveSpeed * Time.fixedDeltaTime;
        transform.position = pos;

        if (pos.x <= -11)
        {
            Destroy(gameObject);
        }

    }
    }

