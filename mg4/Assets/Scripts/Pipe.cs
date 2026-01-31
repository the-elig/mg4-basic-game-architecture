using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private Transform _pipeTransform;
    [SerializeField] private Collider2D _pipeCollider;
    private float _speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        _pipeTransform = GetComponent<Transform>();
        _pipeCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }

    
}
