using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateToCursor : MonoBehaviour
{

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 ScreenPos = Camera.main.ScreenToWorldPoint(mouse);

        Vector2 offset = new Vector2(mouse.x - ScreenPos.x, mouse.y - ScreenPos.y);

        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
