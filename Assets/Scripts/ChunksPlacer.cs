using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunksPlacer : MonoBehaviour
{
    public Transform player;

    public Chunk chunkPrefab;

    private List<Chunk> spawnedChanks= new List<Chunk>();

    Vector3 delta = new Vector3 (9.1269f,2.4670628f, -13.2814f);


    private void Start()
    {
        spawnedChanks.Add(chunkPrefab);
    }
    private void Update()
    {
        if (player.position.y> spawnedChanks[spawnedChanks.Count - 1].End.position.y-30)
        {
            SpawnChunks();
        }
    }
    private void SpawnChunks()
    {
      Chunk newChunk = Instantiate(chunkPrefab);

      newChunk.transform.position = spawnedChanks[spawnedChanks.Count-1].End.position-newChunk.begin.localPosition;

      newChunk.transform.position -= delta;

      spawnedChanks.Add(newChunk);
    }
}
