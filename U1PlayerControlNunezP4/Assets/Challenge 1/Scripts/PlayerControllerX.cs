using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 50.0f;
    public float horizontalInput;
    public float verticalInput;
    private float rotationSpeed = 40.0f;
    public float 


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed * verticalInput);


    }
}
