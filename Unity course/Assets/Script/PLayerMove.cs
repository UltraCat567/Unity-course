using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMove : MonoBehaviour

{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotate;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            Vector3 newPosition = transform.position + transform.forward * _speed * Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.7f, 2.7f);
            transform.position = newPosition;

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, - _rotate * Time.deltaTime, 0);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, _rotate * Time.deltaTime, 0);
       
        }
    }
}
