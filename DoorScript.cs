using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    private int sceneIndex;

    public bool touch;

    public Player player;

	// Use this for initialization
	void Start ()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        //player = gameObject.GetComponentInParent<Player>();
    }
	
	// Update is called once per frame
    // Check if player is touching door and pressing up; if yes, change level
	void Update ()
    {
        //Destry Lock
        //print("SceneIndex: " + sceneIndex);
        if (sceneIndex > 3)
        {
            if (Input.GetButtonDown("Vertical") && touch == true && player.key == true)
            {
                SceneManager.LoadScene(sceneIndex + 1);
            }
        }
        else
        {
            if (Input.GetButtonDown("Vertical") && touch == true)
            {
                SceneManager.LoadScene(sceneIndex + 1);
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
