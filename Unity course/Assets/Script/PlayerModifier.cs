using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModifier : MonoBehaviour
{
    [SerializeField] int _height;
    [SerializeField] int _wigth;

    [SerializeField] Renderer _renderer;

    [SerializeField] Transform _topSpine;
    [SerializeField] Transform _bottomSpine;

    [SerializeField] Transform _colliderTransform;
   


    float _widthMuitiplier = 0.0005f;
    float _heightMuitiplier = 0.01f;


    // Update is called once per frame
    void Update()
    {
        float offSetY = _height * _heightMuitiplier + 0.17f;
        _topSpine.position = _bottomSpine.position + new Vector3(0, offSetY, 0);
        _colliderTransform.localScale = new Vector3(1, 1.84f + _height * _heightMuitiplier, 1);
       
        if (Input.GetKey(KeyCode.T))
        {
            AddWidth(20);
        }

        if (Input.GetKey(KeyCode.Y))
        {
            AddHeight(20);
        }
    }

    public void AddWidth(int value)
    {
        _wigth += value;
        _renderer.material.SetFloat("_PushValue", _wigth * _widthMuitiplier);
    }

    public void AddHeight(int value)
    {
        _height += value;
    }
}
