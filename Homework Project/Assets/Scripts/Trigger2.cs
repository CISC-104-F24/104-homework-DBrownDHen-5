using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hi");
    }

    private void OnTriggerStay(Collider other)
    {
        transform.Rotate(0f, 1.0f, 0f, Space.Self);
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<MeshRenderer>().material.color = new Color(0f, 1.0f, 0f);
    }
}
