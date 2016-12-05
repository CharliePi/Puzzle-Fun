using UnityEngine;
using System.Collections;


public class GroundCheck : MonoBehaviour {

    private Player player;
    

    void Start()
    {
        player = gameObject.GetComponentInParent<Player>();
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        player.grounded = true;
        if (col.gameObject.tag == "deadly" || col.gameObject.tag == "bot" || (col.gameObject.tag == "hammer" && col.gameObject.tag == "hammerplatform"))
        {
            player.death = true;
        }
        if (col.gameObject.tag == "key")
        {
            player.key = true;
            
        }
    }
    
    void OnTriggerStay2D(Collider2D col)
    {
        player.grounded = true;
        if (col.gameObject.tag == "deadly" || col.gameObject.tag == "bot")
        {
            player.death = true;
        }
        if (col.gameObject.tag == "key")
        {
            player.key = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        player.grounded = false;
        if (col.gameObject.tag == "key")
        {
            player.key = true;
        }
    }
}
