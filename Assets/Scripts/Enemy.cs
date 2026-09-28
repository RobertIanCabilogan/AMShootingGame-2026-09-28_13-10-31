using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
    }

    private void OnDestroy()
    {
        FindAnyObjectByType<ScoreManager>().AddScore();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
