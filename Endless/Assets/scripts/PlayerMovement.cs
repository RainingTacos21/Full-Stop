using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpHeight = 5f;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right*speed*Time.deltaTime;
        }
        if (Input.GetKeyDown("w"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }

        if(transform.position.y < -6)
        {
            Debug.Log(transform.position.y);
            GetComponent<HealthManager>().death();
        }
        
        if (transform.position.y > 5)
        {
            Debug.Log(transform.position.y);
            GetComponent<HealthManager>().death();
        }
    }
}
 