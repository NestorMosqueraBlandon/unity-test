using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MultiplePlayer : MonoBehaviour
{
    protected Rigidbody rb;

    public float jumpForce = 5f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        AfterJump();
    }

    protected abstract void AfterJump();
}
