using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private float spawnRate = 2.0f;
    public List<GameObject> prefabs;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    private int score = 0;
    public bool gameActive = true;
    public GameObject titleScreen;

    public void StartGame(int diff)
    {
        gameActive = true;
        score = 0;
        spawnRate /= diff;                                  //Changes spawn rate based on difficulty selected
        Debug.Log("Game spawn rate = " + spawnRate);
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
    }

    public void GameOver()
    {
        gameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    IEnumerator SpawnTarget()
    {
        while(gameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(prefabs[Random.Range(0, prefabs.Count)]);
        }
    }

    public void UpdateScore(int scoreDelta)
    {
        score += scoreDelta;
        if(score < 0)
        {
            score = 0;
        }
        scoreText.text = "Score: " + score;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
