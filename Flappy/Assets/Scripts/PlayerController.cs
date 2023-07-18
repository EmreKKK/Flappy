using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f;
    public float rotationSpeed = 5f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            ScreenControl();
        }

        Rotate();
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    private void Rotate()
    {
        float angle = Mathf.Clamp(rb.velocity.y * rotationSpeed, -30f, 30f);
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "MainCamera")
        {
            SceneManager.LoadScene(0);
        }
    }

    private void ScreenControl()
    {


    }

}
