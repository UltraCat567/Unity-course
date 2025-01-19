using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] PLayerMove _playerMove;
    [SerializeField]  PreFinishBehavior _preFinishBehaviour; 
    [SerializeField] Animator _animator;
    void Start()
    {
        _playerMove.enabled = false; 
        _preFinishBehaviour.enabled = false;
    }

   public void Play()
    {
        _playerMove.enabled = true;
        
    }
    public void StartPreFinishBehavior()
    {
        _playerMove.enabled = false;
        _preFinishBehaviour.enabled = true;
    }

    public void StartFinishBehavior()
    {
        _preFinishBehaviour.enabled = false;
        _animator.SetTrigger("Dance");
    }
}
