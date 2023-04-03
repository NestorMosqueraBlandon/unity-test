using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinglePlayer3 : MultiplePlayer
{
    protected override void AfterJump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}