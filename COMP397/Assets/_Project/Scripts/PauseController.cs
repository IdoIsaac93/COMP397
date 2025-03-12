using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace COMP397
{
    public class PauseController : MonoBehaviour
    {
        [SerializeField] private Rigidbody player;
        [SerializeField] private List<NavMeshAgent> enemies = new();
        private bool isPaused = false;

        public void PauseByTimescale()
        {
            Time.timeScale = 0.0f;
        }

        public void UnpauseByTimeScale()
        {
            Time.timeScale = 1.0f;
        }
        public void PauseByComponents()
        {
            player.constraints = RigidbodyConstraints.FreezeAll;
            foreach (var agent in enemies)
            {
                agent.enabled = false;
            }
        }
        public void UnpauseByComponents()
        {
            player.constraints = RigidbodyConstraints.FreezeRotation;
            foreach (var agent in enemies)
            {
                agent.enabled = true;
            }
        }
    }
}
