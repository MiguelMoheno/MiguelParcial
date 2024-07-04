using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public TextMeshProUGUI scoreText;  
    private int score = 0;




    private void Start()
    {
        
        
    }

    private void Update()
    {
       
    }
    private void Awake()
    {
    //    if (instance == null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(this.gameObject);

    //    }
    //    else
    //    {
    //        Destroy(this.gameObject);
    //    }

    }
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
    

}
