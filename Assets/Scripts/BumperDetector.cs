using UnityEngine;

public class BumperDetector : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private int bumperScore = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Detect collision with objects tagged as "Ball"
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ball")
        {
            Debug.Log("Bumper hit by ball!");
            scoreManager.AddScore(bumperScore);
        }
    }
}
