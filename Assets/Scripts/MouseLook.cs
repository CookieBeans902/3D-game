using UnityEditor;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 150f;
    public Transform playerBody;
    float xRotation = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Adding a message here which is completely random but for testing purposes
    }

    // Update is called once per frame
    void Update()
    {   
        float mouseX = Input.GetAxis("Mouse X")*mouseSensitivity*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*mouseSensitivity*Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-90f,90f);
        playerBody.Rotate(Vector3.up*mouseX);
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
    }
}
