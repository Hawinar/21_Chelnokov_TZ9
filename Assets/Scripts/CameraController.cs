using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject _crane;
    private int _lastScored = 0;

    void Update()
    {
        if(GameManager.Floors > _lastScored && GameManager.Floors % 5 == 0)
        {
            _camera.transform.position = new Vector3(_camera.transform.position.x, _camera.transform.position.y + 3.5f, _camera.transform.position.z);
            _lastScored = GameManager.Floors;
            _crane.transform.position = new Vector3(_crane.transform.position.x, _crane.transform.position.y + 3.5f, _crane.transform.position.z);
        }
    }
}
