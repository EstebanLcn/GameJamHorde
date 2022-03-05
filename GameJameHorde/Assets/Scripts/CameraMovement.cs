using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float _cameraSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(_cameraSpeed * Time.deltaTime, 0, 0);
    }
}
