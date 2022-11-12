using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.APool;
using UProje1.Controllers;

namespace UProje1.Pool
{
    public class RedDragonPool : GenericPool<RedDragonController>
    {
        public static RedDragonPool Instance {get; private set;}
        protected override void SingletonObject()
        {
            if(Instance == null)
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


