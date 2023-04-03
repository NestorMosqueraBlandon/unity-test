using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinglePlayer2 : MultiplePlayer
{
    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    protected override void AfterJump()
    {
        rend.material.color = new Color(Random.value, Random.value, Random.value);
    }
}