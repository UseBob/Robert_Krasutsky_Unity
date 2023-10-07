using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProectionButton : MonoBehaviour
{
    public void Proection(int cameraIndex)
    {
        for (int i = 0; i < transform.childCount; i++) 
        {
            if (transform.GetChild(i).gameObject.activeSelf)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        transform.GetChild(cameraIndex).gameObject.SetActive(true);
    }
}
