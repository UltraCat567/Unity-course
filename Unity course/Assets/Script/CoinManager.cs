using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] float _numberOfCoinsInLevel;
    [SerializeField] TextMeshProUGUI _text;
    
    public void AddOne()
    {
        _numberOfCoinsInLevel += 1;
        _text.text = _numberOfCoinsInLevel.ToString();
    }
}
 