using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.ASpawners;
using UProje1.Spawners;

public class ObstacleTimer : BaseTimer
{
    ObstacleSpawner _obsSpawner;

    private void Awake() 
    {
        _obsSpawner = GetComponent<ObstacleSpawner>();
    }
    
    
    private void Update() 
        {
            _currentSpawnTime += Time.deltaTime;

            if(_currentSpawnTime>_timeBoundary)
            {
               _obsSpawner.Spawn();
                RandomTimeBoundary();
            }
            
        }
    
}
