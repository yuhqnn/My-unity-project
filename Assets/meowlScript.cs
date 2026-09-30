using System.Runtime.Serialization;
using UnityEngine;

public class meowlScript : MonoBehaviour
{
    public Rigidbody2D MyRigidbody;
    public float upSpeed;
    public float xSpeed;
    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logicc").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyRigidbody.linearVelocity = Vector2.up * upSpeed;
        }
        
        if (transform.position.x < 0.09)
        {
            MyRigidbody.linearVelocity = new Vector2(xSpeed,MyRigidbody.linearVelocity.y);
        }

    }

}
