using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int health = 3;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public void death()
    {
        Destroy(gameObject);
        foreach (Image img in hearts)
        {
            img.sprite = emptyHeart;
        }
    }

    //update called once per frame
    void Update()
    {
      foreach (Image img in hearts)
        {
            img.sprite = emptyHeart;
        }
      for(int i = 0; i < health; i++)
        {
            hearts[i].sprite = fullHeart;
        }
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "fire" || collision2D.gameObject.tag == "enemy")
        {
            health = health - 1;
            Debug.Log("ow i touch fire/enemy");
            if(health < 1)
            {
                death();
            }
        }
    }
}
