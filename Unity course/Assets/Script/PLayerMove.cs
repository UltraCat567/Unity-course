using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMove : MonoBehaviour

{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotateSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            transform.position += transform.forward * _speed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * _rotateSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * _rotateSpeed * Time.deltaTime;
       
        }
    }
}
