using UnityEngine;
using UnityEngine.SceneManagement;
public class MeanEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D Collision2D)
    {
        if (Collision2D.gameObject.tag == "Player")

        {
            SceneManager.LoadScene("Lose"); 

        }
    }// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
