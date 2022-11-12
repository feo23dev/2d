using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.Pool;

namespace UProje1.Controllers
{
    public class RedDragonController : EnemyController
    {
        public override void SetEnemyToPool()
        {
            RedDragonPool.Instance.Set(this);
        }
    }




}


