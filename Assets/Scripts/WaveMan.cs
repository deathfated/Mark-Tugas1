using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveMan : MonoBehaviour
{
    private float _timer;
    private float _index = 1;
    [SerializeField] private Text _LevelIndex;

    private void Start()
    {
        _timer = 0f;
        _LevelIndex.text = $"{_index}";
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= 15)
        {
            _LevelIndex.text = $"{_index++}";
            _timer = 0f;
        }
        
    }
}
