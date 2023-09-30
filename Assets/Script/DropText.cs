using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropText : MonoBehaviour
{
    [SerializeField] private TMP_Text text;

    public void NumberText(int index)
    {
        switch (index) 
        {
            case 0: text.text = "Option A";
                break;
            case 1:
                text.text = "Option B";
                break;
            case 2:
                text.text = "Option C";
                break;
        }
    }
}
