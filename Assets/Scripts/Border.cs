using UnityEngine;

public class Border : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "isFirstOnLand")
        {
            Destroy(collision.gameObject);
            GameManager.Lives--;
        }
    }
}
