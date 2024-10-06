using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Vector2 moveValue;
    public float speed;

    void OnMove(InputValue value)
    {
        // Capture the movement input
        moveValue = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        // Convert the input to a 3D vector for movement
        Vector3 movement = new Vector3(moveValue.x, 0.0f, moveValue.y);

        // Apply force to the Rigidbody for movement
        GetComponent<Rigidbody>().AddForce(movement * speed);
    }
}
