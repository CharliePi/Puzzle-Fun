using UnityEngine;
using System.Collections;

public class BotScript : MonoBehaviour
{

    public float maxSpeed = 3;
    public float speed = 75f;
    float h = 1;

    private Animator anim;
    private Rigidbody2D rb2d;
    public bool grounded;
    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        anim.SetFloat("speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("grounded", grounded);
        if (rb2d.velocity.x < -0.1f)
        {
            transform.localScale = new Vector3(-3, 3, 1);
        }
        if (rb2d.velocity.x > 0.1f)
        {
            transform.localScale = new Vector3(3, 3, 1);
        }

    }
    void FixedUpdate()
    {
        if (!grounded)
        {
            h = -h;
            grounded = true;
        }
        rb2d.AddForce((Vector2.right * speed) * h);
        if (rb2d.velocity.x > maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }
        if (rb2d.velocity.x < -maxSpeed)
        {
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }
    }
}
