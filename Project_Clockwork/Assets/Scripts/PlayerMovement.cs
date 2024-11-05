using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public GameObject scoutBotPrefab;
    public Transform ScoutspawnPoint;
    public float possesionTime = 10.0f;
    
    private CameraFollow followPlayerScript;
    private Animator animator;
    private CharacterController characterController;
    private GameObject scoutBot;    
    private bool isPossessing = false;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();

        if (followPlayerScript == null)
        {
            followPlayerScript = Camera.main.GetComponent<CameraFollow>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isPossessing) return;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
        movementDirection.Normalize();

        characterController.SimpleMove(movementDirection * magnitude);

        if (movementDirection != Vector3.zero)
        {
            animator.SetBool("IsRunning_For", true);
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("IsRunning_For", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Greeting", true);
        }
        else
        {
            animator.SetBool("Greeting", false);
        }
        if (Input.GetKeyDown(KeyCode.R) && !isPossessing)
        {
            StartCoroutine(PossessScoutBot());
        }
    }

    IEnumerator PossessScoutBot()
    {
        isPossessing = true;
        scoutBot = Instantiate(scoutBotPrefab, ScoutspawnPoint.position, ScoutspawnPoint.rotation);

        followPlayerScript.SetTarget(scoutBot);

        characterController.enabled = false;
        animator.enabled = false;

        this.enabled = false;

        yield return new WaitForSeconds(possesionTime);

        followPlayerScript.SetTarget(gameObject);
        
        Destroy(scoutBot);

        characterController.enabled = true;
        animator.enabled = true;
        this.enabled = true;
        isPossessing = false;
    }
}
