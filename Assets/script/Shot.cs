using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    private GameObject selectionWeeapon; 
    public GameObject Ammo;
    public GameObject Grenade;
    public GameObject Ball;
    public Camera imgCam;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& selectionWeeapon!=null)
        {
            Instantiate(selectionWeeapon, transform.GetChild(0).position, transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag=="AmmoStand")
        {
            selectionWeeapon = Ammo;
            OffCameraChild();
            imgCam.transform.GetChild(0).gameObject.SetActive(true);
        }

        if (collision.collider.tag == "GrenadeStand")
        {
            selectionWeeapon = Grenade;
            OffCameraChild();
            imgCam.transform.GetChild(1).gameObject.SetActive(true);
        }

        if (collision.collider.tag == "Ball")
        {
            selectionWeeapon = Ball;
            OffCameraChild();
            imgCam.transform.GetChild(2).gameObject.SetActive(true);
        }
    }
    void OffCameraChild()
    {
        for (int i = 0; i < imgCam.transform.childCount; i++)
        {
            if (imgCam.transform.GetChild(i).gameObject.activeSelf)
            {
                imgCam.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
