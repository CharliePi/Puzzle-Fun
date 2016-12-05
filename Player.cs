using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float maxSpeed = 3;
    public float speed = 50f;
    public float jumpPower = 500f;

    public bool grounded;
    public bool death;
    public bool key;

    public GameObject keyObj;

    private Rigidbody2D rb2d;
    private Animator anim;
    private Camera camera;

    public int clickTime = 20;
    public int resetTime = 0;

    private int sceneIndex;

    // Use this for initialization
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        camera = this.GetComponentInChildren<Camera>();
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        key = false;
        keyObj = GameObject.FindWithTag("key");
		clickTime = 20;
    }

    // Update is called once per frame
    void Update()
    {

        anim.SetFloat("speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("grounded", grounded);
        anim.SetBool("dead", death);

        if (Input.GetAxis("Horizontal") < -0.1f && death == false)
        {
            transform.localScale = new Vector3(-3, 3, 1);
        }
        if (Input.GetAxis("Horizontal") > 0.1f && death == false)
        {
            transform.localScale = new Vector3(3, 3, 1);
        }

        if (Input.GetButtonDown("Jump") && grounded == true && death == false)
        {
            rb2d.AddForce(Vector2.up * jumpPower);
        }

        //if(death == true)
        //{
            //anim["death"].wrapMode = WrapMode.Once;
            //anim.Play("death");
        //}

        if(Input.GetKeyDown(KeyCode.R))
                SceneManager.LoadScene(sceneIndex);

        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(1);

        if (key == true)
        {
            Destroy(keyObj);
        }
        //float h = Input.GetAxis("Horizontal");
        //if( Input.GetMouseButton(0) )
        //rb2d.AddForce(Vector2.up * jumpPower);

        //int clickTime = 0;
		if (Input.GetMouseButton(0) && sceneIndex > 4 && death == false && clickTime > 0)
        {

            //Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            Camera camera = Camera.main;
            //Vector2 p = camera.WorldToScreenPoint(new Vector2((Input.mousePosition.x), (Input.mousePosition.y)));
            Vector2 p = camera.ScreenToWorldPoint(new Vector2((Input.mousePosition.x), (Input.mousePosition.y)));
            Vector2 betweenTwoFerns = new Vector2(rb2d.position.x - (p.x), rb2d.position.y - (p.y));
            Vector2 fixedVec = p.normalized;
            if (Mathf.Log(betweenTwoFerns.magnitude) < 1 && clickTime < 25)
                rb2d.AddForce((betweenTwoFerns.normalized * (1 - Mathf.Log(betweenTwoFerns.magnitude)) * 50));
            //rb2d.AddForce(-p);
            clickTime--;
			resetTime = 0;
        }
        else
        {
			if (resetTime > 20 && clickTime < 20)
            { 
				
                clickTime++;
            }
        }
        resetTime++;

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
        if(death == false)
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