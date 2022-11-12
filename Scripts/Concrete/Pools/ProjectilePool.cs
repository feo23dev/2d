using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.APool;
using UProje1.Controllers;

namespace UProje1.Pool

{
    public class ProjectilePool : GenericPool<ProjectileController>
    {
        public static ProjectilePool Instance {get; private set;}
        protected override void SingletonObject()
        {
            if( Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
            else
            {
                Destroy(this.gameObject);
            }
            
        }
    }

}


