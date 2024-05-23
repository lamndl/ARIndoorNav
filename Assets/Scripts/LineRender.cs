using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LineRender : MonoBehaviour
{
    [SerializeField]
    private GameObject target;
    
    private UnityEngine.LineRenderer line;

    private NavMeshPath path;

    private void Start()
    {
        path = new NavMeshPath();
        line = transform.GetComponent<UnityEngine.LineRenderer>();
    }
    private void Update()
    {
        if (target != null)
        {
            NavMesh.CalculatePath(transform.position, target.transform.position, NavMesh.AllAreas, path);
            line.positionCount = path.corners.Length;
            line.SetPositions(path.corners);
            line.enabled = true;
        }

    }
}

