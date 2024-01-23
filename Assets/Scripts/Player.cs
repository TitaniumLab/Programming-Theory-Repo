using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    Vector3 offset = new Vector3(0, 12, -6);
    public bool isAttacking = false;

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (!isAttacking)
        {
            Movement();
        }
    }

    private void LateUpdate()
    {
        SetCameraPos();
    }

    protected void Movement() // ABSTRACTION
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        if (verticalInput != 0 || horizontalInput != 0)
        {
            Vector3 moveTo = transform.position + new Vector3(horizontalInput, 0, verticalInput).normalized;
            agent.destination = moveTo;
        }
        else if (verticalInput == 0 && horizontalInput == 0 && agent.hasPath)
        {
            Vector3 stop = transform.position;
            agent.destination = stop;
        }
    }

    protected void SetCameraPos() // ABSTRACTION
    {
        Camera.main.transform.position = transform.position + offset;
        Camera.main.transform.LookAt(transform.position);
    }
}
