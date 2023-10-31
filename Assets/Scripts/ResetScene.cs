using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetScene : MonoBehaviour
{
    public Button buttonReset;
    public void Respawn()
    {
        PlayerMove.isDead = false;
        buttonReset.gameObject.SetActive(false);
    }
}
