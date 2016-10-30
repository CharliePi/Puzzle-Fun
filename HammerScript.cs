using UnityEngine;
using System.Collections;

public class HammerScript : MonoBehaviour {
    public float maxSpeed = 3;
    public float speed = 75f;
    protected float h = 1;
    public int count;
    public int resetTimer = 100;

    private Rigidbody2D rb2d;
    public bool grounded;

    // Use this for initialization
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        count = 0;
    }

    void FixedUpdate()
    {
        if (count > resetTimer)
        {
            grounded = false;
            count = 0;
        }
        if (!grounded)
        {
            h = -h;
            grounded = true;
        }
        //rb2d.AddConstantForce2D((Vector2.up * speed) * h);
        rb2d.AddRelativeForce((Vector2.up * speed) * h);
        //if (rb2d.velocity.x > maxSpeed)
        //{
        //rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y * 0);
        //}
        //if (rb2d.velocity.x < -maxSpeed)
        //{
        //rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y * 0);
        //}
        count++;
    }
}
