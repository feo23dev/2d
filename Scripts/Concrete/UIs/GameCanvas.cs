using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UProje1.Combats;

namespace UProje1.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;

        private void Awake()
        {
            gameOverPanel = transform.GetChild(1).gameObject;
        }
        private void Start()
        {
            Death death = FindObjectOfType<Death>();
            death.OnDeath += HandleOnDead;  
        }

        public void HandleOnDead()
        {
            gameOverPanel.SetActive(true);
        }



    }

}

