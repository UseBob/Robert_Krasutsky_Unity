using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundInst : MonoBehaviour
{
    public Transform player;
    public Platform platformPref;

    private List<Platform> spawnedPlatformsForward=new List<Platform>();
    private List<Platform> spawnedPlatformsBack = new List<Platform>();

    private void Start()
    {
        spawnedPlatformsForward.Add(platformPref);
        spawnedPlatformsBack.Add(platformPref);
    }

    private void Update()
    {
        if (player.position.x > spawnedPlatformsForward[spawnedPlatformsForward.Count - 1].end.position.x - 10)
        { 
            SpawnPlatformForward();
            Debug.Log(spawnedPlatformsForward.Count);
        }
        else if (player.position.x < spawnedPlatformsBack[spawnedPlatformsBack.Count - 1].begin.position.x + 10)
        {
            SpawnPlatformBack();
        }
    }
    private void SpawnPlatformForward()
    {
        Platform newPlatform = Instantiate(platformPref);
        newPlatform.transform.position = spawnedPlatformsForward[spawnedPlatformsForward.Count - 1].end.position-newPlatform.begin.localPosition;
        spawnedPlatformsForward.Add(newPlatform);
        //if (spawnedPlatformsForward.Count>3)
        //{
        //    if (spawnedPlatformsBack.Count<=1)
        //    {
        //        spawnedPlatformsBack.Add(spawnedPlatformsForward[spawnedPlatformsForward.Count-2]);
        //        Destroy(spawnedPlatformsForward[0].gameObject);
        //        spawnedPlatformsForward.RemoveAt(0);
        //    }
        //}
    }

    private void SpawnPlatformBack()
    {
        Platform newPlatform = Instantiate(platformPref);
        newPlatform.transform.position = spawnedPlatformsBack[spawnedPlatformsBack.Count - 1].begin.position - newPlatform.end.localPosition;
        spawnedPlatformsBack.Add(newPlatform);
    }


}
