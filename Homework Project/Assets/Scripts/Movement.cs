using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public float sprintSpeed = 5.0f;
    public float normalSpeed = 3.0f;

    public float normalJumpHeight = 5.0f;
    public float jumpPower;

    public float maxJumpPower = 10f;

    public float jumpCooldown = 2f;
    public float cooldownTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

        if (Input.GetKey(KeyCode.LeftControl) && !(Input.GetKeyDown(KeyCode.Space)))
        {
            if (!(normalJumpHeight + jumpPower >= maxJumpPower))
            {
                jumpPower += 1.0f * Time.deltaTime;
            }
            else
            {
                jumpPower = maxJumpPower - normalJumpHeight;
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


        if (Input.GetKeyDown(KeyCode.Space) && cooldownTimer == 0f)
        {
            objRigidBody.AddForce(new Vector3(0f, jumpHeight, 0f), ForceMode.Impulse);
            cooldownTimer = jumpCooldown;
        }

        if (cooldownTimer != 0f)
        {
            if (cooldownTimer < 0f)
            {
                cooldownTimer = 0f;
            }
            else
            {
                cooldownTimer -= Time.deltaTime;
            }
        }

        /* FOR PART D, I implemented the following two mechanics:
         * Add a “maximum jump power” to the charge jump
         * Put a “cooldown timer” on the character’s jump
        */
    }
}
