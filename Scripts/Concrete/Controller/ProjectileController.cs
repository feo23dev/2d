using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.AController;
using UProje1.Pool;

namespace UProje1.Controllers

{
    public class ProjectileController : BaseLifeCycleController
    {
      

        private void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.TryGetComponent<EnemyController>(out EnemyController enemy))
            {
                GameManager.Instance.IncreaseScore();
                enemy.KillGameObject();
            }
            KillGameObject();
        }

        public override void KillGameObject()
        {
            ProjectilePool.Instance.Set(this);
        }
        
   
    }

}

