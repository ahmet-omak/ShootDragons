using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class GameManager : MonoBehaviour
{
    [SerializeField] int score=0;
    public static GameManager Instance{get;private set;}

    public event System.Action<int> OnScoreChanged;

    private void Awake() 
    {
        SingletonThisObject();
    }
    private void SingletonThisObject()
    {
        if (Instance==null)
        {
            Instance=this;
            DontDestroyOnLoad(this.gameObject);
        }    
        else
        {
            Destroy(this.gameObject);
        }
    }


    public void LoadMenuScene()
    {
        ResetScore();
        StartCoroutine(LoadMenuSceneAsync());
    }
    private void ResetScore()
    {
        score = 0;
    }

    private IEnumerator LoadMenuSceneAsync()
    {
        yield return SceneManager.LoadSceneAsync("Menu");
    }

    public void AddScore()
    {
        score++;
        OnScoreChanged?.Invoke(score);
    }
}
