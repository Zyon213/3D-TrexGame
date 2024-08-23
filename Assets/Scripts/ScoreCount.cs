using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    
    public Text scoreText;
    public int score;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        score = (int)Time.time;
        scoreText.text = score.ToString();
    }
}
