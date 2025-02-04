using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{

    [SerializeField] int _value;
    [SerializeField] DeformationType _deformationType;
    [SerializeField] GateAppearaence _gateAppearaence;

    private void OnValidate()
    {
        _gateAppearaence.PykPyk(_deformationType, _value); 
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if (playerModifier ) {
            if (_deformationType == DeformationType.Wight)
            {
                playerModifier.AddWidth(_value);
            }
            else if (_deformationType == DeformationType.Height)
            {
                playerModifier.AddHeight(_value);
            }

            Destroy(gameObject);
        }
    }

}
