using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public InputAction moveAction;
    Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
    moveAction.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = moveAction.ReadValue<Vector2>();

        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        //Left and right
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * moveInput.x);
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * moveInput.x);
    }
}
