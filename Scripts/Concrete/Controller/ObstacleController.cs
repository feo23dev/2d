using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.Pool;

namespace UProje1.Controllers

{
    public class ObstacleController : EnemyController
    {
        public override void SetEnemyToPool()
        {
            ObstaclePool.Instance.Set(this);
        }
    }


}


