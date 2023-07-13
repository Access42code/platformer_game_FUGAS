using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Vector3 lastCheckpointPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            lastCheckpointPosition = transform.position;
        }
    }

    public Vector3 GetLastCheckpointPosition()
    {
        return lastCheckpointPosition;
    }
}
