using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private GameObject _block;
    [SerializeField] private GameObject _rope;
  
    private float _time;
    private float _timeBetweenSpawn = (float)Math.E;

    void Update()
    {
        if (Time.time > _time)
        {
            if (GameObject.FindGameObjectsWithTag("isLast").Length == 0 && GameObject.FindGameObjectsWithTag("isFirst").Length == 0)
                Spawn();
            _time = Time.time + _timeBetweenSpawn;
        }
    }

    private void Spawn()
    {
        Instantiate(_block, _rope.transform.position - new Vector3(0,0.5f), _rope.transform.rotation);
    }
}
