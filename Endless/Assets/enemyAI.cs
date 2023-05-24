using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public float speed = 0.1f;
    public float seconds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void goLeft()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x -4, transform.position.y), speed * Time.deltaTime);
    }
    public void goRight()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x + 4, transform.position.y), speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime(seconds);
        if(seconds == 5)
        {
            goLeft();
        }
        else if(seconds == 10)
        {
            goRight();
            seconds = 0;
        }
    }
}
