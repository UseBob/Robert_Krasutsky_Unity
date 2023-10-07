using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RoatteCamer : MonoBehaviour
{
    public float speedRotate=500.0f;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Swipe();
        }
    }

    void Swipe()
    {
        Vector3 delta = Input.GetTouch(0).deltaPosition;

        if (Mathf.Abs(delta.x)>Mathf.Abs(delta.y))
        {
            if (delta.x>0)
            {
                transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * speedRotate);
            }
            else
            {
                transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * speedRotate);
            }
        }
    }
}
