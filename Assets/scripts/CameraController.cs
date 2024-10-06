using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        // Manually set the offset for a better starting camera position
        offset = new Vector3(0, 5, -10); // Adjust these values to your needs
    }

    void LateUpdate()
    {
        // Ensure the camera follows the player with the correct offset
        transform.position = player.transform.position + offset;
    }
}
