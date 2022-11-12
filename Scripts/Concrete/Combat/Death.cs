using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UProje1.Combats
{
    public class Death : MonoBehaviour
    {
        [SerializeField] bool _isDead;
        [SerializeField] float delayTimeScale = 0f;
        public bool IsDead => _isDead;

        public event System.Action OnDeath;

        private void OnCollisionEnter2D(Collision2D other) 
        {
            _isDead = true;
            OnDeath?.Invoke();
            Time.timeScale = delayTimeScale;
        
        }
    
    }



}


