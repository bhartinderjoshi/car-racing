using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
     [SerializeField] NavMeshAgent enemycar;
    [SerializeField] Transform target;
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemycar.SetDestination(target.position);
    }
}
