using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private ScoreManager _scoreManager;
    void Start()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        var ball = other.gameObject.GetComponent<PlayerMovement>();

        if (ball != null)
        {
            _scoreManager.currentScore++;
            Destroy(gameObject);
        }
    }
}
