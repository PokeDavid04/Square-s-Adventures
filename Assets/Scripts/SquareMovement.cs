using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SquareMovement : MonoBehaviour
{

    public float MovimientoSpeed = 10;

    Rigidbody2D rb2D;
    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(MovimientoSpeed, rb2D.velocity.y);
        }
        else if (Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-MovimientoSpeed, rb2D.velocity.y);

        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }
        if (Input.GetKey("up"))
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, MovimientoSpeed);
        }
        else if (Input.GetKey("down"))
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, -MovimientoSpeed);

        }
        else
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, 0);

        }
    }

   
}
