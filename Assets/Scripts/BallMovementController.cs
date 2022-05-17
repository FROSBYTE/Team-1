using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [field:SerializeField] public float MovementSpeed { get; private set; }
    private Rigidbody _rigidbody;
    private Vector3 _acceleration;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 acceleration = Input.acceleration;
        _acceleration = new Vector3(acceleration.x, 0, acceleration.y);
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _acceleration * Time.deltaTime * MovementSpeed;
    }
}
