using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void IntDelegate(int x);
    public event IntDelegate PointsChanged;
    public event IntDelegate EndGame;


    [SerializeField] private Rigidbody2D _playerRigidbody;

    private int _score = 0;
    private bool _gameRunning = true;


    // Start is called before the first frame update
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // jump logic
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerRigidbody.velocity = Vector3.up * 3;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (_gameRunning)
        {

            if (other.CompareTag("PointZone"))
            {
                _score++;
                PointsChanged?.Invoke(_score);
            }

            if (other.CompareTag("Pipe"))
            {
                _gameRunning = false;
                EndGame?.Invoke(_score);
            }
        }
    }
}