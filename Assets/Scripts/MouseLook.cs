using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour

{
    float MouseSensitivty = 100.0f;
    public Transform PlayerBody;
    float xRotation = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivty * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivty * Time.deltaTime;

        xRotation -= mouseY; // Using += inverts the controls of vertical motion.
        xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);

        
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // Using this method instead of below one so that clamping can work. 
        PlayerBody.Rotate(Vector3.up * mouseX);
    }
}
