using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform _target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_target)
        transform.position = _target.position;
    }
}
