using UnityEngine;

namespace Assets.Scripts
{
    public class ItemCollector : MonoBehaviour
    {
        private int collectedItems = 0;

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
            if (collision.CompareTag("Coin"))
            {
                collectedItems++;
                Destroy(collision.gameObject);
            }
        }

        private void OnDestroy()
        {

            PlayerPrefs.SetInt(COLLECTED_ITEMS_KEY, collectedItems);
            PlayerPrefs.Save();
        }
    }
}