using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // transform.position = new Vector3(0, 2, 0);
        //transform.eulerAngles = new Vector3(0, 34, 8);
        //transform.localScale = new Vector3(1, 2, 4);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0.01f, 0);

        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.position += new Vector3(0, -0.01f, 0);

        }

        if (Input.GetMouseButtonDown(0))
        {
            transform.localScale *= 1.2f;
        }

        if (Input.GetMouseButtonDown(1))
        {
            transform.localScale *= 0.8f;
        }

        transform.localEulerAngles = new Vector3(0, Input.mousePosition.x, 0);
        
    }
}
