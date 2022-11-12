using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.ASpawners;
using UProje1.Controllers;
using UProje1.Pool;

namespace UProje1.Spawners
{
    public class ObstacleSpawner : BaseSpawner
    {

        public override void Spawn()
        {
            EnemyController enemy = ObstaclePool.Instance.Get();
            enemy.transform.position = this.transform.position;
            enemy.gameObject.SetActive(true);
            
        }
    }



}

