using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple2 : MonoBehaviour
{
    public Vector3 position;
    public int appleChased = 0;

    void OnEnable()
    {
        Debug.Log(Player2.Instance);
        Player2.Instance.OnChaseApple += SetNewPosition;
    }
    void OnDisable()
    {
        Player2.Instance.OnChaseApple -= SetNewPosition;;
    }
    public void SetNewPosition()
    {
        Debug.Log("a");
        position = new Vector3(Random.Range(-5, 6),Random.Range(-2.5f, 4.5f), 0);
        //transform.position = position;
        //Instantiate()
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
