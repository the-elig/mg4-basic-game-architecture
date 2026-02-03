using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;

    [SerializeField] private GameObject _gameOverScreen;
    [SerializeField] private TMP_Text _finalScoreText;

    // Start is called before the first frame update
    void Start()
    {
        Locator.Instance.Player.PointsChanged += UpdatePointsUI;
        Locator.Instance.Player.EndGame += GameOverUI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdatePointsUI(int score)
    {
        _pointsText.text = "Points: " + score;
    }

    private void GameOverUI(int score)
    {
        _gameOverScreen.SetActive(true);
        _finalScoreText.text = score.ToString();
    }
}
