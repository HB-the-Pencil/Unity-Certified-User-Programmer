using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public Transform cameraTransform;
    public GameManager gameManager;

    [SerializeField] private float speed;

    void Update()
    {
        DoMovement();
    }

    void DoMovement()
    {
        // Read player input.
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        // Normalize the movement.
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;
        
        forward.y = 0;
        right.y = 0;
        
        forward.Normalize();
        right.Normalize();
        
        // Apply movement.
        Vector3 direction = forward * moveVertical + right * moveHorizontal;
        rb.AddForce(direction * (speed * Time.deltaTime), ForceMode.Impulse);
    }
}
