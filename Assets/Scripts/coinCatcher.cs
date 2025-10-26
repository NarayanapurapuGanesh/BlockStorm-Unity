using UnityEngine;
using UnityEngine.UI;

public class CoinCatcher : MonoBehaviour
{
    public AudioSource coinSound;     // 🎵 Assign in Inspector
    public Text scoreText;            // 🧾 Assign your UI Text here
    private int score = 0;

    private void Start()
    {
        UpdateScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            if (coinSound != null)
            {
                coinSound.Play();
            }

            Destroy(other.gameObject);

            score++;
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
