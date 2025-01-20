using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float _rotationsSpeed;
    [SerializeField] GameObject _ice;
 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, _rotationsSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinManager>().AddOne();
        Destroy(gameObject);
        Instantiate(_ice, transform.position, transform.rotation);
    }
}
