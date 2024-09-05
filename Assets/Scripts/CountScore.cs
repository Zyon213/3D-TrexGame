using UnityEngine.UI;
using UnityEngine;

public class CountScore : MonoBehaviour
{
    public GameObject sound;
    public Text scoreText;
    public Text highScoreText;
    public float scoreValue = 0f;
    public float pointIncreasedPerSec = 1f;
    [SerializeField] PlayerMovement playerMovement;
    public int points;
    // Start is called before the first frame update
    public void Start()
    {
        UpdateHighScoreText();
    }

    // Update is called once per frame
    void Update()
    {
    
        scoreText.text = ((int)scoreValue).ToString("D5");
        scoreValue += pointIncreasedPerSec * Time.deltaTime;
        points = (int)scoreValue;

        CheckHighScore();

       int score = (int)Time.time;
        int lapTime = score % 10;
        if (lapTime == 0)
        {
            playerMovement.speed += playerMovement.speedIncreasedPerPoint;
        }

        if ((points % 100 == 0) && points > 0)
        {
            sound.GetComponent<AudioManager>().PlaySound();
        }

    }
    void CheckHighScore()
    {
        if (points > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", points);
        }
    }

    void UpdateHighScoreText()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString("D5");
        highScoreText.text = $"HI {highScoreText.text}";

    }
}
