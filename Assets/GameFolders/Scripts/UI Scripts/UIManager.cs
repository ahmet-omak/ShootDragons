using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager: MonoBehaviour
{
    TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        OnScoreAdded(score: 0);
    }

    private void Start()
    {
        GameManager.Instance.OnScoreChanged += OnScoreAdded;
    }

    private void OnScoreAdded(int score)
    {
        scoreText.text = $"Score:{score}";
    }
}
