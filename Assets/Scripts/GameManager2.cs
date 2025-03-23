using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public GameObject PanelLose;

    private void Start()
    {
        PanelLose.SetActive(false);
    }
    void OnEnable()
    {
        Player2.OnDead += ShowLosePanel;
    }
    void OnDisable()
    {
        Player2.OnDead -= ShowLosePanel; 
    }
    void ShowLosePanel()
    {
        PanelLose.SetActive(true);
    }
    public void RestartScene()
    {
        PanelLose.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}
