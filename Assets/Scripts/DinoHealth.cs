using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class DinoHealth : MonoBehaviour
{
    public static event Action OnPlayerDeath;

  

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Dino"))
        {
            OnPlayerDeath?.Invoke();
        }
    }
}
