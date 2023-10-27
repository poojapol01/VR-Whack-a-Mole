using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticleInput;

    [SerializeField]
    private float speed = 10.0f;

    private void Update()
    {
        // Set Our Input Axis(Keyboard Arrows)
        horizontalInput = Input.GetAxis("Horizontal");
        verticleInput = Input.GetAxis("Vertical");

        // Move when the user presses the arrow keys
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticleInput * Time.deltaTime * speed);

    }
}
