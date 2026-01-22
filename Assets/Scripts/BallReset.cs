using UnityEngine;

public class BallReset : MonoBehaviour
{
    public Transform target; // The target position to reset the ball to

    public Transform tpHere;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            //BallResetPosition(other.gameObject);

            target.transform.position = tpHere.position;
        }
    }
}