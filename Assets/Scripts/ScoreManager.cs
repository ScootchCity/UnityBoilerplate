using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int currentScore = 0;
    void Update()
    {
        text.text = this.currentScore.ToString();
    }
}
