using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace COMP397
{
    public class EnemyController : MonoBehaviour , IObserver
    {
        private NavMeshAgent agent;
        [SerializeField] private PlayerController player;
        [SerializeField] private List<Transform> waypoints = new();
        private int index = 0;
        private Vector3 destination;
        [SerializeField] private float distanceThreshold;

        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
            destination = waypoints[index].position;
            player = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        }

        private void OnEnable()
        {
            player.AddObserver(this);
        }

        private void OnDisable()
        {
            player.RemoveObserver(this);
        }

        private void Start()
        {
            agent.destination = destination;
        }
        private void Update()
        {
            if (Vector3.Distance(destination, transform.position) < distanceThreshold)
            {
                index = (index + 1) % waypoints.Count;
                destination = waypoints[index].position;
                agent.destination = destination;
            }
        }

        private void OnDrawGizmos()
        {
            if (waypoints.Count > 0)
            {
                Gizmos.color = Color.green;
                for(int i = 0; i < waypoints.Count; i++)
                {
                    Gizmos.DrawSphere(waypoints[i].position, distanceThreshold);
                    if(i > 0)
                    {
                        Gizmos.DrawLine(waypoints[i -1].position, waypoints[i].position);
                    }
                }
            }
        }

        public void OnNotify()
        {
            Debug.Log($"Notified by the subject");
        }
    }
}
