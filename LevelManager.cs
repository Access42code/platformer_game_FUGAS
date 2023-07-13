using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int nextLevelIndex;
    private int collectedItems;

    private const string COLLECTED_ITEMS_KEY = "CollectedItems";

    private void Start()
    {
        
        if (PlayerPrefs.HasKey(COLLECTED_ITEMS_KEY))
        {
            collectedItems = PlayerPrefs.GetInt(COLLECTED_ITEMS_KEY);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            PlayerPrefs.SetInt(COLLECTED_ITEMS_KEY, collectedItems);
            PlayerPrefs.Save();

           
            SceneManager.LoadScene(nextLevelIndex);
        }
    }

    public void IncreaseCollectedItems()
    {
        collectedItems++;
    }
}
