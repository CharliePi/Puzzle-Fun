using UnityEngine;
using System.Collections;

public class SwitchScript : MonoBehaviour {
    public bool touch;

    private LazerScript lazer;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        lazer = gameObject.GetComponentInParent<LazerScript>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    // Check if player is touching door and pressing up; if yes, change level
    void Update()
    {
        anim.SetBool("on", lazer.active);
        if (lazer.active == true)
            {
                if (Input.GetButtonDown("Vertical") && touch == true)
                {
                    lazer.active = false;
                }
            }
            else
            {
                if (Input.GetButtonDown("Vertical") && touch == true)
                {
                    lazer.active = true;
                }
            }
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
    public bool getActive()
    {
        return lazer.active;
    }
}
