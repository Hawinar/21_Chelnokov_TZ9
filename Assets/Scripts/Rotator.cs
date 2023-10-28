using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private GameObject _Rope;
    private bool _rotateDirection = false;
  
    private void Update()
    {

        switch (_rotateDirection)
        {
            case false:
                _Rope.transform.Rotate(0, 0, 0.02f);
                break;
            case true:
                _Rope.transform.Rotate(0, 0, -0.02f);
                break;
        }
       

        if (_Rope.transform.rotation.z >= 0.2)
        {
            _rotateDirection = true;
        }

        if (_Rope.transform.rotation.z <= -0.2)
        {
            _rotateDirection = false;
        }
       


        GameManager.RopeQuaternion = _Rope.transform.rotation;
    }
}
