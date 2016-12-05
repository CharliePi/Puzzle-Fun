using UnityEngine;
using System.Collections;

public class LazerScript : MonoBehaviour {

    private LazerScript lazer;
    private Rigidbody2D rb2d;
    public bool active;

    // Use this for initialization
    void Start()
    {
        lazer = gameObject.GetComponentInParent<LazerScript>();
        rb2d = gameObject.GetComponentInParent<Rigidbody2D>();
        active = true;
    }

    // Update is called once per frame
    // Check if player is touching door and pressing up; if yes, change level
    void FixedUpdate()
    {

        foreach (Transform child in this.transform)
        {
            if (active && child.gameObject.activeSelf == false)
            {
                child.gameObject.SetActive(true);

            }
            else if (!active && child.gameObject.activeSelf == true)
            {
                child.gameObject.SetActive(false);
            }
        }

    }
}
