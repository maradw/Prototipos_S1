using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class Player2 : SingletonNotPersistent<Player2>
{
    private float _horizontal;
    private float _vertical;
    [SerializeField] private Rigidbody myRBD;
    [SerializeField] private float velocity = 5f;

    Vector3 direction;
    public int length = 1;
    public int score = 0;
    public GameObject[] Limits;
    public  event Action OnDead; 
    public event Action OnChaseApple; 


    [SerializeField] GameObject bodyPrefab; 
    [SerializeField] List<Transform> bodyParts = new List<Transform>();

    public int _basicDistance ;
    bool _isDead = false;

    private void Awake()
    {
        myRBD = GetComponent<Rigidbody>();
    }
    public void OnMovement(InputAction.CallbackContext move)
    {
        _horizontal = move.ReadValue<Vector2>().x;
        _vertical = move.ReadValue<Vector2>().y;

    }

    void Grow()
    {
        Vector3 newPosition = transform.position *_basicDistance;//nofuncionaXD
        if (bodyParts.Count > 0)
        {
            newPosition = bodyParts[bodyParts.Count - 1].position;
        }

        GameObject newBodyPart = Instantiate(bodyPrefab, newPosition, Quaternion.identity);
        bodyParts.Add(newBodyPart.transform);
    }

    void MoveBodyParts(Vector3 headPreviousPosition)
    {
        if (bodyParts.Count > 0)
        {
            Vector3 previousPosition = headPreviousPosition;

            for (int i = 0; i < bodyParts.Count; i++)
            {
                Vector3 temp = bodyParts[i].position;
                bodyParts[i].position = Vector3.Lerp(bodyParts[i].position, previousPosition, 0.5f);
                previousPosition = temp;
            }
        }
    }
    public void FixedUpdate()
    {
        Vector3 previousPosition = transform.position;
        myRBD.velocity = new Vector3(_horizontal * velocity, _vertical * velocity); //
        MoveBodyParts(previousPosition);
    }
    void CheckMovement()
    {
        //
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="Limits") 
        {
            Debug.Log("limits");
            OnDead?.Invoke();
        }
        else if  (collision.gameObject.tag == "Apple")
        {
            score ++;
            length++;
            OnChaseApple?.Invoke();
            Debug.Log("xd" + score);
            Grow();

        }
    }

}
