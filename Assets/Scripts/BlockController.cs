using System.Collections;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    [SerializeField] private GameObject _block;
    [SerializeField] private Rigidbody2D _body2D;

    private bool _isStable = false;
    WaitForSeconds seconds = new WaitForSeconds(2f);


    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("isFirst").Length == 0 && GameObject.FindGameObjectsWithTag("isFirstOnLand").Length == 0)
            _body2D.gameObject.tag = "isFirst";
    }
    void Update()
    {
        if (_body2D.transform.tag == "isLast" || _body2D.transform.tag == "isFirst")
        {
            _body2D.transform.rotation = GameManager.RopeQuaternion;
            _body2D.transform.position = new Vector3(GameManager.PositionX - 3.75f, GameManager.PositionY - 1.2f);
        }

    }
    private void OnMouseDown()
    {
        _body2D.transform.parent = null;
        _body2D.gravityScale = 1f;
        if (_body2D.gameObject.tag != "isFirst")
            _body2D.gameObject.tag = "isFlying";
        else
            _body2D.gameObject.tag = "isFirstOnLand";
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isStable = true;
        StartCoroutine(CheckStable());
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        _isStable = false;
    }
    IEnumerator CheckStable()
    {
        yield return seconds;
        if (_isStable)
        {
            if (_body2D.gameObject.tag == "isFlying")
                _body2D.gameObject.tag = "isOnLand";
            _body2D.bodyType = RigidbodyType2D.Static;
            GameManager.Floors++;
        }
    }
}
