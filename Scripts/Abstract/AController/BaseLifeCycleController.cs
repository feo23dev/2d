using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.Pool;

namespace UProje1.AController
{
    public abstract class BaseLifeCycleController : MonoBehaviour
    {
        [SerializeField] float maxLife = 5f;
        protected float _currentTime;

        private void Update() 
        {
            _currentTime += Time.deltaTime;
            if(_currentTime > maxLife)
            {
               KillGameObject();
            }
            
        }

        public abstract void KillGameObject();
        
    
    }


}

