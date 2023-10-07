using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTarget : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(target,new Vector3(-5,1,8),Quaternion.identity);
            Instantiate(target, new Vector3(0, 1, 8), Quaternion.identity);
            Instantiate(target, new Vector3(5, 1, 8), Quaternion.identity);
        }
    }
}
