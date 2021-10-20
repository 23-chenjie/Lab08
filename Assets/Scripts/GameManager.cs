using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    int score;

    public Text scoretext;

    void Awake()
    {
        instance = this;
    }

    public void addscore(int add)
    {
        score += add;
        scoretext.text = "Score: " + score;
    }
}
