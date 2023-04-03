using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinglePlayer1 : MultiplePlayer
{
    protected override void AfterJump()
    {
        transform.Rotate(Vector3.up, Random.Range(0f, 360f));
    }
}