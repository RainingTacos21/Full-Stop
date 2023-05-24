using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        // Debug.Log("krjhg3irgf");
        if (collision2D.gameObject.tag == "enemy")
        {
            Debug.Log("stab enemy");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
