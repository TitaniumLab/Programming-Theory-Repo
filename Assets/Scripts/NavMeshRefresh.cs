using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class NavMeshRefresh : MonoBehaviour
{
    private NavMeshSurface navMeshSurface;
    private void Start()
    {
        navMeshSurface = GetComponent<NavMeshSurface>();
        InvokeRepeating("_NavMeshRefresh", 0, 0.1f);
    }

    private void _NavMeshRefresh()
    {
        navMeshSurface.BuildNavMesh();
    }
}
