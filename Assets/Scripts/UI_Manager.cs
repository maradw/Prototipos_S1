using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI actualScore;
    public TextMeshProUGUI highScore;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        actualScore.text = "Score: " + Player2.Instance.score;
    }
}
