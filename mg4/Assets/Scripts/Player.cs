using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerRigidbody;
    
    private int _currentScore;
    private int _highscore;


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
}
