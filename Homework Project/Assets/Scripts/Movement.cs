using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float sprintSpeed = 5.0f;
    public float normalSpeed = 3.0f;

    public float normalJumpHeight = 5.0f;
    public float jumpPower;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // bool isVoteKeyPressed = Input.GetKeyDown(voteKey);

        Rigidbody objRigidBody = GetComponent<Rigidbody>();

        Vector3 movementDirection = Vector3.zero;

        float moveSpeed;

        float jumpHeight = normalJumpHeight + jumpPower;
        

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = sprintSpeed;
        }
        else
        {
            moveSpeed = normalSpeed;
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            while (!(Input.GetKey(KeyCode.Space)))
            {
                jumpPower += 0.1f;
            }
        }
        else
        {
            jumpPower = 0f;
        }


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


        if (Input.GetKeyDown(KeyCode.Space))
        {
            objRigidBody.AddForce(new Vector3(0f, jumpHeight, 0f), ForceMode.Impulse);
        }
    }
}
