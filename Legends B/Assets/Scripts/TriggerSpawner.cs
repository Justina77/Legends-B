using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawner : Spawner
{
    // Start is called before the first frame update
    public override void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartSpawn();
        }
    }
}
