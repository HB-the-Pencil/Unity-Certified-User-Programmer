using System;
using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        
        // Update Y position for a curve.
        transform.position = new Vector3(
            transform.position.x,
            Mathf.Cos(transform.position.x / 5) * 2 - 3,
            transform.position.z);

        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}
