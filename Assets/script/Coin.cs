using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    public int points = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Score scoreManager = FindObjectOfType<Score>();
            if (scoreManager != null)
            {
                scoreManager.AddPoints(points);
            }
            Destroy(transform.parent.parent.parent.gameObject);
            print("into");
        }

    }
}
