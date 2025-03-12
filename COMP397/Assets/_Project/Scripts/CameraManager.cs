using Unity.Cinemachine;
using UnityEngine;

namespace COMP397
{
    public class CameraManager : MonoBehaviour
    {
        [SerializeField] private CinemachineCamera freeLookCam;
        [SerializeField] private Transform playerTransform;

        private void Awake()
        {
            //Cursor.lockState = CursorLockMode.Locked;
            //Cursor.visible = false;
            if (playerTransform != null) { return; }
            playerTransform = GameObject.FindWithTag("Player").transform;
        }

            private void OnEnable()
        {
            freeLookCam.Target.TrackingTarget = playerTransform;
        }
    }
}
