using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace UProje1.UIs

{
    
    public class DisplayScore : MonoBehaviour
    {
        TextMeshProUGUI _scoreText;
        private void Awake() 
        {
            _scoreText = GetComponent<TextMeshProUGUI>();   
        }
        private void Start() 
        {
            GameManager.Instance.OnScoreChanged += HandleOnScoreChanged; 
            HandleOnScoreChanged(); 
        }   

        private void OnDisable() 
        {
            GameManager.Instance.OnScoreChanged -= HandleOnScoreChanged; 
        }
        

        private void HandleOnScoreChanged(int score = 0)
        {
            _scoreText.text = "SCORE" + ":" + score.ToString();
        }

    
    }



}

