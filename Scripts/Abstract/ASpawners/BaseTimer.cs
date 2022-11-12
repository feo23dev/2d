using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.Spawners;

namespace UProje1.ASpawners
{
    public  abstract class BaseTimer : MonoBehaviour
    {
        [Range(2f,5f)]
        [SerializeField] float maxSpawnTime = 3f;
        [Range(0.3f,1.5f)]
        [SerializeField] float minSpawnTime = 1f;
        ObstacleSpawner _obstacleSpawner;

        public float _currentSpawnTime;
        public float _timeBoundary;

        

         private void Start() 
        {
            RandomTimeBoundary();
        }

        private void Update() 
        {
            _currentSpawnTime += Time.deltaTime;

            if(_currentSpawnTime>_timeBoundary)
            {
                //Spawn();
                RandomTimeBoundary();
            }
            
        }

        public void RandomTimeBoundary()
        {
            _currentSpawnTime =0;
            _timeBoundary = Random.Range(minSpawnTime,maxSpawnTime);
        }
    }


        





}

