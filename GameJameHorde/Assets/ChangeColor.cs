using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.GetComponent<Camera>().backgroundColor = new Color(228f / 255f, 234f / 255f, 241f / 255f, 0f);

    }
}
