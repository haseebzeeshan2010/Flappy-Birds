using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody2D;
    public float upForce = 200f;

    private LogicScript logic;

    public bool birdisalive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && birdisalive)
        {
            myrigidbody2D.linearVelocity = Vector2.up * upForce;
        }

    }

    // Called when the Collider2D other enters the trigger to end the game
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
}
