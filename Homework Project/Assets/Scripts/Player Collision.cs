using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("JumpPad"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0f, 5f, 0f), ForceMode.Impulse);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("SpeedPad"))
        {
            GetComponent<Movement>().normalSpeed = 5;
            GetComponent<Movement>().sprintSpeed = 7;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("SpeedPad"))
        {
            GetComponent<Movement>().normalSpeed = 3;
            GetComponent<Movement>().sprintSpeed = 5;
        }
        Debug.Log("No longer colliding with something");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Color Changer"))
        {
            GetComponent<MeshRenderer>().material.color = other.gameObject.GetComponent<MeshRenderer>().material.color;
        }
    }
}
