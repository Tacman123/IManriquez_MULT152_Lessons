using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkRotation : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, 24, Player.transform.position.z);
        transform.rotation = Quaternion.Euler(90, Player.transform.eulerAngles.y, 0);
    }
}
