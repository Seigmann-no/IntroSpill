using UnityEngine;

class CameraFollow : MonoBehaviour
{
    public Transform target; // The target for the camera to follow
    private void Update()
    {
        transform.LookAt(target);

    }
}