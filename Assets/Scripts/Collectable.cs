using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public ScoreManager ScoreManagerRef;
    void Start()
    {
        ScoreManagerRef = FindObjectOfType<ScoreManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        var ball = other.gameObject.GetComponent<PlayerMovement>();

        if (ball != null)
        {
            ScoreManagerRef.Increment();
            Destroy(this.gameObject);
        }
    }
}
