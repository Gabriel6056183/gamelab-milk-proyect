using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    public float moveSpeed = 4;
    bool moveUp;
    bool moveDown;
    bool moveLeft;
    bool moveRight;
    float xMin = -8.43f;
    float xMax = 8.43f;
    float yMin = -4.73f;
    float yMax = 4.73f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveUp = Input.GetKey(KeyCode.W);
        moveDown = Input.GetKey(KeyCode.S);
        moveLeft = Input.GetKey(KeyCode.A);
        moveRight = Input.GetKey(KeyCode.D);

    }
    private void FixedUpdate()
    {
        Vector2 movement = Vector2.zero;
        if (moveUp) movement += Vector2.up;
        if (moveDown) movement += Vector2.down;
        if (moveLeft) movement += Vector2.left;
        if (moveRight) movement += Vector2.right;
    
Vector3 newPos = transform.position + (Vector3)(movement * moveSpeed * Time.deltaTime);

        newPos.x = Mathf.Clamp(newPos.x, xMin, xMax);
    newPos.y = Mathf.Clamp(newPos.y, yMin, yMax);

    transform.position = newPos;
    
        
    }
}
