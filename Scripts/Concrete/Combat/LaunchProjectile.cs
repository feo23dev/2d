using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.Controllers;
using UProje1.Pool;

namespace UProje1.Combats

{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] Transform projectilePosition;
        [SerializeField] GameObject projectileParent;
        [SerializeField] float delayProjectile =1f; //every1sec,we'll launch
        float _currentDelayTime;
        bool _canLaunch;

        private void Update() 
        {
            _currentDelayTime += Time.deltaTime;
            if(_currentDelayTime > delayProjectile)
            {
                _canLaunch = true;
                _currentDelayTime =0f;
            }
            
        }

        public void Launch()
        {
            if(_canLaunch)
            {
                ProjectileController newProjectile =  ProjectilePool.Instance.Get();
                newProjectile.gameObject.SetActive(true);
                newProjectile.transform.position = projectilePosition.transform.position; 
                _canLaunch = false;
            }
            
        }

    


    }


}

