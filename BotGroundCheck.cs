using UnityEngine;
using System.Collections;

public class BotGroundCheck : MonoBehaviour {
    private BotScript bot;


    void Start()
    {
        bot = gameObject.GetComponentInParent<BotScript>();

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "botplatform")
        {
            bot.grounded = true;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "botplatform")
        {
            bot.grounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "botplatform")
        {
            bot.grounded = false;
        }
    }
}
