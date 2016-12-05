using UnityEngine;
using System.Collections;

public class TextControler : MonoBehaviour {

    public MeshRenderer text;

    public bool displayText = true;

    // Use this for initialization
    void Start()
    {
        text = gameObject.GetComponent<MeshRenderer>();
        if (displayText)
            text.enabled = true;
    }


    void OnTriggerEnter(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            text.enabled = !displayText;
            displayText = !displayText;
        }
    }
    void OnTriggerExit(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
        }
    }
}
