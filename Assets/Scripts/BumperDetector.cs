using UnityEngine;

public class BumperDetector : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private int bumperScore = 100;
    [SerializeField] private float duration = 2f; // Duration of the timer in seconds
    private float timer;
    private bool isRunning = false;
    private Color originalColor;
    private ParticleSystem bumperParticlesSystem;
    private SoundManager soundManager;
    [SerializeField] private AudioClip bumperSFX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        bumperParticlesSystem = GetComponent<ParticleSystem>();
        isRunning = true;
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

    }
    private void Update()
    {
        if(isRunning == true)
        {
            BumperEffectDelay();
        }

    }

    // Detect collision with objects tagged as "Ball"
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ball")
        {
            scoreManager.AddScore(bumperScore);
            bumperParticlesSystem.Play();
            originalColor = GetComponent<Renderer>().material.color;
            GetComponent<Renderer>().material.color = Color.red;
            isRunning = true;
            timer = duration;
        }
    }
    private void BumperEffectDelay()
    {
        timer -= Time.deltaTime; // Decrease the timer by the time elapsed since the last frame
        if (timer <= 0f)
        {
            GetComponent<Renderer>().material.color = originalColor;
            Debug.Log("Bumper effect ended.");
        }
    }

}
