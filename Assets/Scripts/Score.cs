using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour {
    public static Score instance;
    
    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _bestScoreText;

    private int _score;

    private const string PREF_BEST_SCORE = "BestScore";

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    private void Start() {
        _currentScoreText.text = _score.ToString();

        _bestScoreText.text = PlayerPrefs.GetInt(PREF_BEST_SCORE, 0).ToString();
        UpdateBestScore();
    }

    private void UpdateBestScore() {
        if (_score <= PlayerPrefs.GetInt(PREF_BEST_SCORE)) return;
        PlayerPrefs.SetInt(PREF_BEST_SCORE, _score);
        _bestScoreText.text = _score.ToString();
    }

    public void UpdateScore() {
        _score++;
        _currentScoreText.text = _score.ToString();
        UpdateBestScore();
    }
}
