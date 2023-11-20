using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score = 0;
    [SerializeField] private GameObject _panel;

    private void Awake()
    {
        _panel.gameObject.SetActive(false);
        Application.targetFrameRate = 60;
    }

    public void ScoreUP()
    {
        score++;
        //_scoreText.text = score.ToString();
        if (score> Spawner.randomBallers-1)
        {
            Win();
        }
    }

    void Win()
    {
        _panel.gameObject.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
