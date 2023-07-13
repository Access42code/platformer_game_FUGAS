using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public Checkpoint initialCheckpoint;

    private GameObject playerInstance;
    private Vector3 respawnPosition;

    private void Start()
    {
        respawnPosition = initialCheckpoint.GetLastCheckpointPosition();
        SpawnPlayer();
    }

    private void Update()
    {
        if (playerInstance.transform.position.y < -10f)
        {
            // Гравець провалився, повертаємо його до останньої позиції чекпоінту
            RespawnPlayer();
        }
    }

    private void SpawnPlayer()
    {
        playerInstance = Instantiate(playerPrefab, respawnPosition, Quaternion.identity);
    }

    private void RespawnPlayer()
    {
        playerInstance.transform.position = respawnPosition;
    }
}