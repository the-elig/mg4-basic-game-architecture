using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Grid _grid;
    [SerializeField] private GameObject[] _pipePrefabs;
    private float _spawnGap, _timeToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        // first pipe spawn
        Instantiate(_pipePrefabs[Random.Range(0, 4)], _grid.transform);

        // start spawn timer
        _spawnGap = 4;
        _timeToSpawn = _spawnGap;
    }

    // Update is called once per frame
    void Update()
    {
        _timeToSpawn -= Time.deltaTime;

        if (_timeToSpawn <= 0)
        {
            _timeToSpawn = _spawnGap;

            int ran = Random.Range(0, 4);
            Instantiate(_pipePrefabs[ran], _grid.transform);
        }
    }
}
