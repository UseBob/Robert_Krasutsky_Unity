using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSparrow : MonoBehaviour
{
    public GameObject[] sparrows;

    private int sparrNumber;

    private void Start()
    {
        for (int i = 0; i < sparrows.Length; i++)
        {
            if (sparrows[i].activeSelf)
            {
                sparrNumber = i;
            }
        }
        //for (int i = 0; i < sparrows.starrSparrows.Length; i++) 
        //{
        //    if (sparrows.starrSparrows[i].activeSelf) 
        //    {
        //        sparrNumber=i;
        //    }
        //}
    }
    
    public void nextSparrow()
    {
        sparrows[sparrNumber].SetActive(false);
        if (sparrNumber == sparrows.Length-1)
        {
            sparrNumber = 0;
        }
        else
        {
            sparrNumber++;
        }
        sparrows[sparrNumber].SetActive(true);
    }

    public void backSparrow()
    {
        sparrows[sparrNumber].SetActive(false);
        if (sparrNumber == 0)
        {
            sparrNumber = 3;
        }
        else
        {
            sparrNumber--;
        }
        sparrows[sparrNumber].SetActive(true);
    }
}
