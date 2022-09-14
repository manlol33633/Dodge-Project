using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float rotationSpeed = 720;
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    public static bool hasKey;
    public static float[] position;
    public static Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hasKey = false;
        position = new float[2];
        position[0] = transform.position.x;
        position[1] = transform.position.y;
        pos = transform.position;
        transform.position = new Vector3(-19.5f, -1.5f, 0);
        transform.rotation = Quaternion.Euler(0, 0, 180);
    }
    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movementDirection.Normalize();
    }

    void FixedUpdate() {
        rb.velocity = movementDirection * speed;
        if (movementDirection != Vector2.zero) {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
