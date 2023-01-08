using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spowner : MonoBehaviour
{
    [SerializeField] private float _startTime;
    [SerializeField] private Enemy _prefab;

    public Transform spownPoint;

    private float _timeBetweenSpowns = 6;
    private float _totalGameTime;

    void Start()
    {
        _totalGameTime = _timeBetweenSpowns - _startTime;
    }

    void Update()
    {
        if(_totalGameTime >= _timeBetweenSpowns) 
        {
            Instantiate(_prefab, spownPoint.transform.position, Quaternion.identity);
            _totalGameTime = 0;
        }
        else 
        {
            _totalGameTime += Time.deltaTime;
        }
    }
}
