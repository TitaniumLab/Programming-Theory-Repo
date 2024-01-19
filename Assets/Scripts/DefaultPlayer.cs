using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultPlayer : MonoBehaviour
{
    protected int life = 20;
    protected float movementSpeed = 1;
    [SerializeField]
    protected float horizontalInput;
    protected float verticalInput;

    private void Update()
    {
        Movement();
    }

    protected void Movement()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
