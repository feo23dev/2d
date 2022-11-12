using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.APool;
using UProje1.Controllers;

namespace UProje1.Pool
{
    public class ObstaclePool : GenericPool<ObstacleController>
    {
        public static ObstaclePool Instance {get; private set;} 
        protected override void SingletonObject()
        {
            if( Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
            
        }
    }



}


