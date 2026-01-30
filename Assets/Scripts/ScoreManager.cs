using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    //Holde score
    [SerializeField] private int currentTotalScore = 0;
    //Oppdatere score
    //Vise score på skjermen
    [SerializeField] private TMP_Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    //Add score to totalscore
    //Run debuglog to check result
    public void AddScore(int score)
    {
        currentTotalScore = currentTotalScore + score;
        scoreText.text = currentTotalScore.ToString();

        Debug.Log(currentTotalScore);
    }
}
