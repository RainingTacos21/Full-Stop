using UnityEngine;
using UnityEngine.UI;

public class HeartSystem : MonoBehaviour
{
    public int maxHearts = 3;
    public int currentHearts;
    public Image[] heartImages;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Start()
    {
        currentHearts = maxHearts;
        UpdateHeartUI();
    }

    public void LoseHeart()
    {
        currentHearts--;
        if (currentHearts < 0)
        {
            currentHearts = 0;
            // Perform actions when the player runs out of hearts (e.g., game over).
        }
        UpdateHeartUI();
    }



    private void UpdateHeartUI()
    {
        for (int i = 0; i < maxHearts; i++)
        {
            if (i < currentHearts)
            {
                heartImages[i].sprite = fullHeart;
            }
            else
            {
                heartImages[i].sprite = emptyHeart;
            }
        }
    }
}

