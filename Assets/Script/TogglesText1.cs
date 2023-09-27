using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TogglesText1 : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void Text(string buttonText)
    {
        text.text = buttonText;
    }
}
