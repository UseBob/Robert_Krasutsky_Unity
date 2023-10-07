using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject[] starrSparrows;

    private Renderer[] _rend = new Renderer[4];
    public Material material;
    private void Start()
    {
        for (int i = 0; i < starrSparrows.Length; i++) 
        {
            _rend[i] = starrSparrows[i].GetComponent<Renderer>();
        }
    }
    public void NeedColor(Material material)
    {
       for(int i=0;i<starrSparrows.Length;i++)
        {
            if (starrSparrows[i].activeSelf)
            {
                _rend[i].material = material;
            }
        }
    }
}
