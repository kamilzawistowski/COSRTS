using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRTS : MonoBehaviour
{

    public float speed = 50f;
    public Camera minimap;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(h * speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(h * speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0,v * speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0,v * speed * Time.deltaTime, 0);
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            minimap.orthographicSize++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) 
        {
            minimap.orthographicSize--;
        }
    }


}
