using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum DeformationType
{
    Wight,
    Height
}
public class GateAppearaence : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] Image _topImage;
    [SerializeField] Image _glassImage;

    [SerializeField] Color _colorPositive;
    [SerializeField] Color _colorNegative;

    [SerializeField] int _value;

    [SerializeField] DeformationType _deformationType;

    //»конки ширины
    [SerializeField] GameObject _expandLable;
    [SerializeField] GameObject _shrinkLable;

    [SerializeField] GameObject _upLable;
    [SerializeField] GameObject _downLable;


    private void OnValidate()
    {
        string prefix = "";

        _text.text = _value.ToString();
        if (_value > 0)
        {
            prefix = "+";
            SetColor(_colorPositive);
        }else if (_value == 0)
        {
            SetColor(Color.grey);
        }
        else
        {
            SetColor(_colorNegative);

        }
        _text.text = prefix + _value.ToString();

        _expandLable.SetActive(false);
        _shrinkLable.SetActive(false);
        _upLable.SetActive(false);
        _downLable.SetActive(false);

        if (_deformationType == DeformationType.Wight)
        {
            if (_value >0)
            {
                _expandLable.SetActive(true);
            }
            else
            {
                _shrinkLable.SetActive(true);
            }

        }
        else if (_deformationType == DeformationType.Height)
        {
            if (_value > 0)
            {
                _upLable.SetActive(true);
            }
            else
            {
                _downLable.SetActive(true);
            }
        }
    }
    void SetColor(Color color)
    {
        _topImage.color = color;
        _glassImage.color = new Color(color.r, color.g, color.b, 0.5f);
    }
}
