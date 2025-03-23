using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple2 : MonoBehaviour
{
    public Vector3 position;
    public int appleChased = 0;

    void OnEnable()
    {
        Player2.OnChaseApple += SetNewPosition;
    }
    void OnDisable()
    {
        Player2.OnChaseApple -= SetNewPosition;;
    }
    public void SetNewPosition()
    {
        position = new Vector3(UnityEngine.Random.Range(-5, 6), UnityEngine.Random.Range(-2.5f, 4.5f), 0);
        transform.position =position;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
