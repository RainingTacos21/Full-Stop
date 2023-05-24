using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public int health;
    public float speed = 5f;
    [Range(0f, 100f)] public float offset;
    private Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        health = 2;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, new Vector2(startPos.x + offset, transform.position.y)) <= 1.0f)
        {
            offset -= (offset * 2);
        }
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(startPos.x + offset, transform.position.y), (speed * Time.deltaTime));
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "weapon")
        {
            Debug.Log("enemy hit , solider down");
            health = health - 1;
            if(health < 1)
            {
                Destroy(gameObject);
            }
        }
    }
}
