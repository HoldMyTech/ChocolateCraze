using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D RB;  
    public int Speed = 3;
	public int Health = 3;
 	public AudioClip SoundEffect; 
    public AudioSource AS;
    void Start()
 	
    {
        
    }
    private void OnCollisionEnter2D(Collision2D Collision2D)
    {

        if (Collision2D.gameObject.tag == "WinCon")

        {
             SceneManager.LoadScene("Win"); 
        }
 if (Collision2D.gameObject.tag == "Coin")

        {
              AS.PlayOneShot(SoundEffect);
        }

    }


    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0,0);
       
        //Then we use if statement to figure out what that variable should look like
        
        //If I hold the right arrow key, the player should move right. . .
        if (Input.GetKey(KeyCode.RightArrow))
        {
            vel.x = Speed;
        }
        //If I hold the left arrow, the player should move left. . .
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vel.x = -Speed;
        }
        //If I hold the up arrow, the player should move up. . .
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vel.y = Speed;
        }
        //If I hold the down arrow, the player should move down. . .
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vel.y = -Speed;
        }

        if (transform.position.y < -7)
        {
            //Debug.Log("Player is out of range");
            Vector3 pos = transform.position;
            pos.y = -5;
            transform.position = pos;
            
        }


        
        //Finally, I take that variable and I feed it to the component in charge of movement
        RB.linearVelocity = vel;
    }
    }

