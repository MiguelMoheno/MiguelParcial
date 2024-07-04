using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    
    public float moveX;
    public float velocity;
    public Vector3 move;
    private CharacterController ctrl;
    

    private void Start()
    {
        ctrl = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Movement();

        
    }

    private void Movement()
    {

        move = transform.right * moveX;
        ctrl.Move(move * velocity * Time.deltaTime);

        moveX = Input.GetAxis("Horizontal");
    }

    




}
