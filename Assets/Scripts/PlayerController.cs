using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Movement turning (Editable in inspector)
    public float speed = 5.0f;
    public float turnSpeed = 100f;

    //Input System action (In inspector for key binding)
    public InputAction moveAction;

    //Current input value (x = left/right y = forward/backward)
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Enable the MoveAction so it starts reading input
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //Reads the 2D vector from the MoveAction (x = horizontal y = vertical)
        moveInput = moveAction.ReadValue<Vector2>();

        //move the vehicle forward/backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        //move the vehicle left/right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}
