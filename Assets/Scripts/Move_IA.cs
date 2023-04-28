using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class Move_IA : MonoBehaviour
{
    public List<NavMeshAgent> agents;
    private Camera mainCamera;



    void Start()
    {
        mainCamera = Camera.main;
    }



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);



            if (Physics.Raycast(ray, out hit))
            {
                foreach (NavMeshAgent agent in agents)
                {
                    
                    agent.SetDestination(hit.point);
                }
            }
        }
    }
}