using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger3 : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Player.GetComponent<Movement>().normalSpeed = 1;
        Player.GetComponent<Movement>().sprintSpeed = 3;
    }
    private void OnTriggerExit(Collider other)
    {
        Player.GetComponent<Movement>().normalSpeed = 3;
        Player.GetComponent<Movement>().sprintSpeed = 5;
    }
}
