using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winTrigger;    
    public bool winCondition;

    [SerializeField] GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        winCondition = false;
        winTrigger.gameObject.SetActive(false);
        pauseMenu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.gameObject.SetActive(true);
        }
    }

    private void WinCon()
    {
        if(winCondition == true)
        {
            winTrigger.gameObject.SetActive(true);
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
