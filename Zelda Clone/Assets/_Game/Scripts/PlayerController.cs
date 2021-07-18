using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10;

    private Rigidbody2D rb;

    private void Awake() => 
        rb = GetComponent<Rigidbody2D>();

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            rb.velocity = Vector2.up * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S))
            rb.velocity = Vector2.down * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.A))
            rb.velocity = Vector2.left * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.D))
            rb.velocity = Vector2.right * speed * Time.deltaTime;
        else
            rb.velocity = Vector2.zero;
    }
}
