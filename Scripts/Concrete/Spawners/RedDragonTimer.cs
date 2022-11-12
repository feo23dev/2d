using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.ASpawners;
using UProje1.Spawners;

public class RedDragonTimer : BaseTimer
{
    RedDragonSpawner _redDragonSpawner;
    private void Awake() 
    {
        _redDragonSpawner = GetComponent<RedDragonSpawner>();
    }


    private void Update() 
    {
        {
            _currentSpawnTime += Time.deltaTime;

            if(_currentSpawnTime>_timeBoundary)
            {
               _redDragonSpawner.Spawn();
                RandomTimeBoundary();
            }
            
        }
        
    }

    
}
