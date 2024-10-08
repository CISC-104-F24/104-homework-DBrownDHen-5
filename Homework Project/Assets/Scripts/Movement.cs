using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // bool isVoteKeyPressed = Input.GetKeyDown(voteKey);

        Vector3 movementDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movementDirection += transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementDirection += (transform.right * -1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementDirection += (transform.forward * -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementDirection += transform.right;
        }
        transform.position += movementDirection.normalized * moveSpeed * Time.deltaTime;
    }
}
