using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    private int sceneIndex;

    public bool touch;

	// Use this for initialization
    // Create player object
	void Start ()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
	
	// Update is called once per frame
    // Check if player is touching door and pressing up; if yes, change level
	void Update ()
    {
	    if (Input.GetButtonDown("Vertical") && touch == true)
        {
            SceneManager.LoadScene(sceneIndex + 1);
            print(touch);
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
