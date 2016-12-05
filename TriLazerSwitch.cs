using UnityEngine;
using System.Collections;

public class TriLazerSwitch : MonoBehaviour
{

    public bool touch;

    public LazerScript me;
    public LazerScript mid;
    public LazerScript laz2;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    // Check if player is touching door and pressing up; if yes, change level
    void Update()
    {
        anim.SetBool("on", me.active);
        if (me.active == true)
        {
            if (Input.GetButtonDown("Vertical") && touch == true)
            {
                me.active = false;
                laz2.active = false;
                mid.active = true;

            }
        }
        else
        {
            if (Input.GetButtonDown("Vertical") && touch == true)
            {
                me.active = true;
                laz2.active = true;
                mid.active = false;
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


}
