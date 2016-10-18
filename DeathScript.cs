using UnityEngine;
using System.Collections;

public class DeathScript : MonoBehaviour {

    public bool touch;
    private Player player;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start ()
    {
        //TODO
        player = gameObject.GetComponentInParent<Player>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //TODO
        print(touch);
        if (touch == true)
        {
            Destroy(player);
            Destroy(this);
            Destroy(rb2d);

        }
        print(touch);
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        touch = true;
    }
    void OnTriggerStay2D(Collider2D col)
    {
        touch = true;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        touch = false;
    }
}
