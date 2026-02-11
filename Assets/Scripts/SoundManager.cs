using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource backGroundMusic_AS;
    [SerializeField] private AudioSource SFX_AS;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        backGroundMusic_AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlaySFX(AudioClip clip)
    {
        
    }
}
