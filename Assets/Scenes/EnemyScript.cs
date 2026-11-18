using UnityEngine;
using UnityEngine.AI;
public class EnemyScript : MonoBehaviour

{
    [SerializeField] Transform target;
    NavMeshAgent agent;
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
  
    

    void Update()
    {
        agent.SetDestination(target.position);
    }
}