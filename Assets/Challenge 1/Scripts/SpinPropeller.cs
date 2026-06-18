using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float Spinspeed = 15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spinspeed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (Vector3.forward, Spinspeed);
    }
}
