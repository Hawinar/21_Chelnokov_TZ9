using UnityEngine;

public class CraneMover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb2d;
    private bool _moveDirection = false;
    void Update()
    {
        switch (_moveDirection)
        {
            case false:
                _rb2d.MovePosition(new Vector2(_rb2d.position.x + 0.03f, _rb2d.position.y));
                break;
            case true:
                _rb2d.MovePosition(new Vector2(_rb2d.position.x - 0.03f, _rb2d.position.y));
                break;
        }
        if (_rb2d.position.x >= 4)
        {
            _moveDirection = true;
        }

        if (_rb2d.position.x <= 2)
        {
            _moveDirection = false;
        }
        GameManager.PositionX = _rb2d.position.x;
        GameManager.PositionY = _rb2d.position.y;
    }
}
