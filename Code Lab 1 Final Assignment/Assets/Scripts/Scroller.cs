using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    /*public float _speed = 1;
    public float _wrapPoint = 10;

    float _position;

    void Start()
    {
        _position = Vector3.Dot(transform.position, transform.right);
    }

    void Update()
    {
        _position += Time.deltaTime * _speed;

        if (_position > _wrapPoint) _position -= _wrapPoint * 2;

        transform.position = transform.forward * _position;
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("star"))
        {
            other.gameObject.SetActive(false);
            print("star off");
        }
    }


}
