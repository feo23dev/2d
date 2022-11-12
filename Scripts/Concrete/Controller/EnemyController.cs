using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.AController;
using UProje1.Pool;

namespace UProje1.Controllers
{
    public abstract class EnemyController : BaseLifeCycleController
    {
        public override void KillGameObject()
        {
            _currentTime = 0f;
            SetEnemyToPool();
        }

        public abstract void SetEnemyToPool();
    }
    
    

}

