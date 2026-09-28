using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerScript : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootPoint;
    public float smoothSpeed = 0f;
    private void Start()
    {
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Mouse.current.position.ReadValue();
        mouse = Camera.main.ScreenToWorldPoint(mouse);
        mouse.z = 0;
        transform.position = Vector3.Lerp(transform.position, mouse, smoothSpeed * Time.deltaTime);
            
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(bullet, shootPoint.position, Quaternion.identity);
        }
    }
}
