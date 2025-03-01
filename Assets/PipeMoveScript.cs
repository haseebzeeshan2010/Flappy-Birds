using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float movespeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed * Time.deltaTime);
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }

    }
}
