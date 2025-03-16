using UnityEngine;
using UnityEngine.SceneManagement;
public class WinScript : MonoBehaviour

{
    public AudioClip SoundEffect2;
    public AudioSource AS;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AS.PlayOneShot(SoundEffect2);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.T))
        {
            SceneManager.LoadScene("Title"); 
        } 
    }
}