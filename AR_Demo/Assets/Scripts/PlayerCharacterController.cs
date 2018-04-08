using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerCharacterController : MonoBehaviour {

    public LayerMask movementMask;
    private NavMeshAgent navMeshAgent;

    // Use this for initialization
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f, movementMask))
            {
                MoveToPoint(hit.point);
            }
        }

    }

    private void MoveToPoint(Vector3 point)
    {
        navMeshAgent.SetDestination(point);
    }
}
