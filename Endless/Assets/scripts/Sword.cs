using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private Vector2 startPos;
    public string dir;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        dir = "right";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            dir = "left";
        }
        if (Input.GetKey("d"))
        {
            dir = "right";
        }

        GameObject player = GameObject.Find("Player");
        Transform playerTransform = player.transform;
        // get player position
        Vector2 position = playerTransform.position;

        if (dir == "left")
        {
            transform.position = new Vector2(position.x - 0.55f, position.y);
        }
        else
        {
            transform.position = new Vector2(position.x + 0.55f, position.y);
        }
    }

}
