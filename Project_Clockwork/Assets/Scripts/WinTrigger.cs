using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TriggerObject"))
        {
            gameManager.winCondition01 = true;
            Debug.Log("Win condition set to true.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Resets trigger if conditions are not met
        if(other.gameObject.CompareTag("TriggerObject"))
        {
            gameManager.winCondition01 = false;
            Debug.Log("Trigger object removed. Win condition set to false.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
