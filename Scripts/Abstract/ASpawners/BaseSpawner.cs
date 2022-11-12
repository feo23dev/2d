using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.Controllers;
using UProje1.Spawners;

namespace UProje1.ASpawners
{

    public abstract class BaseSpawner : MonoBehaviour
    {
        
        

        private void Awake() 
        {
            
        }

        

        

        public abstract void Spawn();
        
    }

}

