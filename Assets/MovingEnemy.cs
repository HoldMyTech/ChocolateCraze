using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    public Rigidbody2D RB;
    public float enemySpeed = 0.1f;
    public float LeftEdge = -6;
    public float RightEdge = -3;

// public int targetXPosition = -3;

// public int initialXPosition = -6;

    void Start()
    {
        //Vector2 initialPosition = new Vector3 (-6,2,0);  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(enemySpeed * Time.deltaTime, 0);
        if (transform.position.x < LeftEdge)
        {
            //Vector2 vel = new Vector2(initialXPosition, 2);
            //transform.position = new Vector3(targetXPosition, 2, 0);
            enemySpeed = Mathf.Abs(enemySpeed);
        }

        if (transform.position.x > RightEdge)
        {
            enemySpeed = -Mathf.Abs(enemySpeed);
            //targetXPosition = initialXPosition;
        }

    }
}
