using System.Net;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float duration = 2f; // Duration of the timer in seconds
    private float timer;
    private bool isRunning = false; // Flag to indicate if the timer is running
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        timer = duration; // Initialize the timer with the specified duration
        isRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; // Decrease the timer by the time elapsed since the last frame
        if (timer <=0f)
        {
            Debug.Log("Timer has finished!"); // Log a message when the timer finishes
        }

    }


}
