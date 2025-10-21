using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SnakeController : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5f;
    public float turnSpeed = 180f;
    public Transform head;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (head == null) head = this.transform;
    }

    void Update()
    {
        HandleInput();
    }

    /// <summary>
    /// Simple input handler: horizontal for yaw, vertical for forward/back.
    /// This is a minimal skeleton to illustrate where to integrate more advanced movement (3D steering, physics forces).
    /// </summary>
    void HandleInput()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 forward = head.forward * v;
        Vector3 move = forward * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + move);

        Quaternion turn = Quaternion.Euler(0f, h * turnSpeed * Time.deltaTime, 0f);
        rb.MoveRotation(rb.rotation * turn);
    }
}