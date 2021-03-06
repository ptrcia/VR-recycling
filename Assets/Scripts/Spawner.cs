using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> objectsToSpawn= new List<GameObject>();
    public float timeToSpawn;
    private float currentTimeToSpawn;
    public bool isTimer;
    public bool isRandomized;
    void Start()
    {
        currentTimeToSpawn = timeToSpawn;
    }
    void Update()
    {
        if (isTimer)
        {
            UpdateTimer();
        }
    }
    private void UpdateTimer()
    {
        if (currentTimeToSpawn > 0){ 
            currentTimeToSpawn -= Time.deltaTime;
        }else{
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }

    public void SpawnObject()
    {
        int index = isRandomized ? Random.Range(0, objectsToSpawn.Count) : 0;
        if(objectsToSpawn.Count > 0)
        {
            Instantiate(objectsToSpawn[index], transform.position, transform.rotation);
        }
    }
}
