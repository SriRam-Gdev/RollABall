using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        Vector3 movement = new Vector3(input.x, 0, input.y);
        rb.AddForce(movement * speed);
    }
}
