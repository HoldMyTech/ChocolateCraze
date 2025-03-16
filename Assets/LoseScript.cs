using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseScript : MonoBehaviour
{
    public AudioClip SoundEffect3;
    public AudioSource AS;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AS.PlayOneShot(SoundEffect3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Gameplay"); 
        } 
    }
}