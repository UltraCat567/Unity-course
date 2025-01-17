using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]private float _height;
    [SerializeField] private int _numberOfCoins;
    [SerializeField] private string _name;

    [SerializeField] private Light  _sun;
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _cube;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1, _height, 1);
        _sun.intensity = 2;
        _sun.color = Color.red;
        _camera.fieldOfView = 120;

    }

    // Update is called once per frame
    void Update()
    {
        _cube.position = transform.position + new Vector3(0, 6, 0);
    }
}
