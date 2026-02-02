using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private GameObject _pointZonePrefab;

    [SerializeField] private Transform _pipeTransform;
    private float _speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        _pipeTransform = GetComponent<Transform>();

        Instantiate(_pointZonePrefab, _pipeTransform);
    }

    // Update is called once per frame
    void Update()
    {
        // constantly move left
        transform.Translate(Vector3.left * _speed * Time.deltaTime);

        // destroy once off screen
        if (_pipeTransform.position.x <= -9)
        {
            Destroy(gameObject);
        }
    }

    
}
