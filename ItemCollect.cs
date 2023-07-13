using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            
            LevelManager levelManager = FindObjectOfType<LevelManager>();
            levelManager.IncreaseCollectedItems();

            Destroy(collision.gameObject);
        }
    }
}