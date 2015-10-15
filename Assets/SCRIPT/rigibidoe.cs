using UnityEngine;
using System.Collections;

public class rigibidoe : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody rbody;
    Vector3 inputVector;
    // Use this for initialization
    public Transform myCamera;
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float jump = Input.GetButtonDown("Jump") ? 5f : 0f;

        inputVector = new Vector3(Input.GetAxis("Horizontal"), jump, Input.GetAxis("Vertical"));

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(0f, mouseX, 0f); myCamera.Rotate(0f, 0f, 0f);
    }


    // Update is for graphics and input whereas FIXEUPDATE is for physica
    void FixedUpdate()
    {
        float yVelocity = rbody.velocity.y;
        rbody.velocity += new Vector3(0f, yVelocity, 0f);
        rbody.velocity = transform.TransformDirection(inputVector) * moveSpeed;

    }
}
