using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool hasReachedCheckpoint = false;
    private int coinCount = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Checkpoint"))
        {
            hasReachedCheckpoint = true;
        }
        else if (collision.CompareTag("Coin"))
        {
            coinCount++;
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Finish") && hasReachedCheckpoint)
        {
            Debug.Log("Рівень завершено!");
        }
    }
}