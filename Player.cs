using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public float maxSpeed = 3;
    public float speed = 50f;
    public float jumpPower = 500f;

    public bool grounded;

    private Rigidbody2D rb2d;
    private Animator anim;
    private Camera camera;

    // Use this for initialization
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        camera = this.GetComponentInChildren<Camera>();

    }

    // Update is called once per frame
    void Update()
    {

        anim.SetFloat("speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("grounded", grounded);
        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            transform.localScale = new Vector3(-8, 8, 1);
        }
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            transform.localScale = new Vector3(8, 8, 1);
        }

        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            rb2d.AddForce(Vector2.up * jumpPower);
        }
        float h = Input.GetAxis("Horizontal");
        //if( Input.GetMouseButton(0) )
        //rb2d.AddForce(Vector2.up * jumpPower);


        if (Input.GetMouseButton(0))
        {

            //Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            Camera camera = Camera.main;
            //Vector2 p = camera.WorldToScreenPoint(new Vector2((Input.mousePosition.x), (Input.mousePosition.y)));
            Vector2 p = camera.ScreenToWorldPoint(new Vector2((Input.mousePosition.x), (Input.mousePosition.y)));
            Vector2 betweenTwoFerns = new Vector2(rb2d.position.x - (p.x), rb2d.position.y - (p.y));
            Vector2 fixedVec = p.normalized;
            print("p" + p);
            print("adj pos " + betweenTwoFerns);
            print("charpos " + rb2d.position);
            print("charpos " + Input.mousePosition.x + " " + Input.mousePosition.y);
            rb2d.AddForce((betweenTwoFerns.normalized * (100-Mathf.Log(betweenTwoFerns.magnitude))));
            //rb2d.AddForce(-p);
        }

    }
    void FixedUpdate()
    {
        Vector3 easeVelocity = rb2d.velocity;
        easeVelocity.y = rb2d.velocity.y;
        easeVelocity.z = 0f;
        easeVelocity.x *= .75f;

        // fake friction / easing the x speed of player

        if (grounded)
        {
            rb2d.velocity = easeVelocity;
        }

        float h = Input.GetAxis("Horizontal");
        //h = speed of player -1 or 1 depending on direction
        //moving player
        rb2d.AddForce((Vector2.right * speed) * h);
        //limits max speed
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