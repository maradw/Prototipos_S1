using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager2 : MonoBehaviour
{
    public int HighScore = 0;
    public UI_Manager UIManager;

    private void Start()
    {
        //Player2.Instance.OnChaseApple += UpdateScore;
    }

    void UpdateScore()
    {
        HighScore = Mathf.Max(HighScore, Player2.Instance.score);
        //UIManager.UpdateText(Player2.Instance.score);
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}
