using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndUI : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dino")
            SceneManager.LoadScene(1);

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
