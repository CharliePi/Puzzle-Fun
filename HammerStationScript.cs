using UnityEngine;
using System.Collections;

public class HammerStationScript : MonoBehaviour {

    private HammerScript hammer;


    void Start()
    {
        hammer = gameObject.GetComponentInParent<HammerScript>();

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "hammerplatform")
        {
            hammer.grounded = true;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "hammerplatform")
        {
            hammer.grounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "hammerplatform")
        {
            hammer.grounded = false;
        }
    }
}
