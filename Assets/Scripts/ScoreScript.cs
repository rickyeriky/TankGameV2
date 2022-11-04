using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public int score1 = 5;
    public int score2 = 5;
    public TMPro.TextMeshProUGUI ScoreTextP1;
    public TMPro.TextMeshProUGUI ScoreTextP2;

    // Start is called before the first frame update
    void Start()
    {
        score1 = 5;
        score2 = 5;
    }

    public void AddP1Score()
    {
        score1--;
        ScoreTextP1.text = score1.ToString();
    }

    public void AddP2Score()
    {
        score2 -- ;
        ScoreTextP2.text = score2.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
