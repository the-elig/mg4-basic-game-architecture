using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private Grid _grid;
    [SerializeField] private GameObject[] _pipePrefabs;
    private float _spawnGap, _timeToSpawn;

    private bool _gameRunning = true; //i know this is bad game design, i don't care

    // Start is called before the first frame update
    void Start()
    {
        Locator.Instance.Player.EndGame += StopGame;

        // first pipe spawn
        Instantiate(_pipePrefabs[Random.Range(0, 4)], _grid.transform);

        // start spawn timer
        _spawnGap = 4;
        _timeToSpawn = _spawnGap;
    }

    // Update is called once per frame
    void Update()
    {
        if (_gameRunning)
        {
            // constantly spawn pipes
            _timeToSpawn -= Time.deltaTime;

            if (_timeToSpawn <= 0)
            {
                _timeToSpawn = _spawnGap;

                int ran = Random.Range(0, 4);
                Instantiate(_pipePrefabs[ran], _grid.transform);
            }
        }
    }

    private void StopGame(int score)
    {
        _gameRunning = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
