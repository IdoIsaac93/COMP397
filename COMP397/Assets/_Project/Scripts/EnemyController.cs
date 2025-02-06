using UnityEngine;
using UnityEngine.AI;

namespace COMP397
{
    public class EnemyController : MonoBehaviour
    {
        private NavMeshAgent agent;

        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
        }
        private void Update()
        {
            Vector3 destination = GameObject.FindWithTag("Player").transform.position;
            agent.destination = destination;
        }
    }
}
