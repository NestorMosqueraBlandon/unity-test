using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private MultiplePlayer[] players;

    private void Start()
    {
        players = FindObjectsOfType<MultiplePlayer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (MultiplePlayer player in players)
            {
                player.Jump();
            }
        }
    }
}
