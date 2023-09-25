using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I : MonoBehaviour
{
    public GameObject cube;
    public GameObject flower;
    public GameObject sphere;

    private void Update()
    {
        if (cube != null && Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(cube);
            cube.transform.position = new Vector3(-8, 0, -10);
        }

        if (flower != null && Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(flower);
            flower.transform.position = new Vector3(-2, 1.5f, -4);
        }

        if (sphere != null && Input.GetKeyDown(KeyCode.Alpha3))
        {
            Instantiate(sphere);
            sphere.transform.position = new Vector3(4, 1,-8);
        }
    }
}
