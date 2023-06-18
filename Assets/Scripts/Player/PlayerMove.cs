using System.Collections;
using System.Collections.Generic;

using UnityEngine;
/*
public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;

    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector3.forward, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(leftRightSpeed * Time.deltaTime * Vector3.left);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(leftRightSpeed * Time.deltaTime * Vector3.left * -1);
        }

    }
}
*/

/*public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float LeftRightSpeed = 4;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.forward * moveSpeed * Time.fixedDeltaTime;

        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity += transform.right * horizontalInput * LeftRightSpeed * Time.fixedDeltaTime;
    }
}*/


public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;

    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector3.forward, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(leftRightSpeed * Time.deltaTime * Vector3.left);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(leftRightSpeed * Time.deltaTime * -Vector3.left);
        }
    }
}



/*public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;

    void Update()
    {
        Debug.Log("Input.GetKey(KeyCode.A): " + Input.GetKey(KeyCode.A));
        Debug.Log("Input.GetKey(KeyCode.LeftArrow): " + Input.GetKey(KeyCode.LeftArrow));

        transform.Translate(moveSpeed * Time.deltaTime * Vector3.forward, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Moving left");
            transform.Translate(leftRightSpeed * Time.deltaTime * Vector3.left);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Moving right");
            transform.Translate(leftRightSpeed * Time.deltaTime * Vector3.right);
        }
    }
}
*/