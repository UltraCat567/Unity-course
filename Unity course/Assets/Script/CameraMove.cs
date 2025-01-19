using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform _target;

    private void Start()
    {
        transform.parent = null;
    }
    void Update()
    {
        if (_target)
        {
            transform.position = _target.position;
        }
            
    }
}
