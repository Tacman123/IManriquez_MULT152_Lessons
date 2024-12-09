using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool winCondition01 = false;
    public bool winCondition02 = false;
    public bool winCondition03 = false;
    public GameObject winTrigger;

    private PlayerHealth playerHealth;

    [SerializeField] GameObject pauseMenu;
    
    // Start is called before the first frame update
    void Start()
    {               
        
        pauseMenu.gameObject.SetActive(false);
        playerHealth = GetComponent<PlayerHealth>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.gameObject.SetActive(true);
        }

        CheckEnemeyCount();

        WinMenuEnable();
        
    }

    private void WinMenuEnable()
    {
        if (winCondition01 && winCondition02)
        {
            winTrigger.SetActive(true);
        }
        else
        {
            winTrigger.SetActive(false);
        }
    }
    
    private void CheckEnemeyCount()
    {
        int enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        Debug.Log("Number of enemies:" + enemyCount);
        if(enemyCount == 0)
        {
            winCondition02 = true;
            Debug.Log("All enemies defeated");
        }
    }
}
