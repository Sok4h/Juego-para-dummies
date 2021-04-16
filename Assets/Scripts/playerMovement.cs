using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Awake()
    {   
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, rb.velocity.y);

        if (Input.GetAxis("Horizontal") == -1)
        {


            rb.GetComponent<SpriteRenderer>().flipX = true;

        }

        else {

            rb.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKey(KeyCode.Space)) {


            rb.velocity = new Vector2(rb.velocity.x, speed);
        
        
        }
    }
}
