using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
