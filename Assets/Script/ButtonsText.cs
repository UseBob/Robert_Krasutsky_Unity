using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonText : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void Text(string buttonText)
    {
        if (gameObject.GetComponent<Toggle>().isOn==true)
        {
            text.text = buttonText.ToString();
        }
        else
        {
            text.text = string.Empty.ToString();
        }
    }
}
