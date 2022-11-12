using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;
    public static GameManager Instance { get; private set; }

    public event System.Action<int> OnScoreChanged; 
    private void Awake()
    {
        SingletonThisGameobjetct();
    }

    private void SingletonThisGameobjetct()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void IncreaseScore()
    {
        score++;
        OnScoreChanged?.Invoke(score); // method gibi event'i çağırıyoruz.
    }

    public void RestartGame()
    {
        score = 0;
        Time.timeScale =1f;
        StartCoroutine(RestartGameAsync());
    }

    private IEnumerator RestartGameAsync()
    {
        yield return SceneManager.LoadSceneAsync("Game");
    }

    
    


}
