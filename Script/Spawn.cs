using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private SpawnGroup[] spawns;
    [SerializeField] private int adjFloat;
    // Start is called before the first frame update
    void Start()
    {
        if (spawns != null)
        {
            for (int i = 0; i < spawns.Length; i++)
            {
                for (int j = 0; j < spawns[i].numberOfSpawn; j++)
                {
                    float spawnXVal = Random.Range(-spawns[i].x * adjFloat, spawns[i].x * adjFloat + 1);
                    spawnXVal = spawnXVal / adjFloat;
                    float spawnYVal = Random.Range(-spawns[i].y * adjFloat, spawns[i].y * adjFloat + 1);
                    spawnYVal = spawnYVal / adjFloat;
                    Instantiate(spawns[i].type, new Vector3(spawnXVal + spawns[i].xOffSet, 0, spawnYVal + spawns[i].yOffSet), Quaternion.identity, transform);
                }                
            }
        }        
    }
}
