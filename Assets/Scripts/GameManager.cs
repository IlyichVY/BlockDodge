using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _block;
    [SerializeField]
    private float _maxX = 2.28f;
    [SerializeField]
    private float _spawnRateSeconds;
    [SerializeField]
    private Transform _spawnPoint;
    [SerializeField]
    private GameObject _startSlate;
    [SerializeField]
    public TextMeshProUGUI ScoreText;
    [SerializeField]
    public GameObject UICanvas;

    private bool _gameStarted = false;

    [HideInInspector]
    public int Score = 0;

    private void Start()
    {
        _startSlate.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !_gameStarted)
        {
            StartSpawningBlocks();
            _gameStarted = true;
            UICanvas.SetActive(true);
        }
    }

    private void StartSpawningBlocks()
    {
        InvokeRepeating("SpawnBlocks", 0.5f, _spawnRateSeconds);
        _startSlate.SetActive(false);
        //ScoreText.SetActive(true);
    }

    private void SpawnBlocks()
    {
        Vector2 spawnPosition = _spawnPoint.position;
        spawnPosition.x = Random.Range(-_maxX, _maxX);
        Instantiate(_block, spawnPosition, Quaternion.identity);
    }
}