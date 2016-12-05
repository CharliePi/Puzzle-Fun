using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GUIScript : MonoBehaviour
{
    private int sceneIndex;

    /*
     * Used for initialization
     * Makes a sceneIndex variable that holds the number of the current scene index to later be used to load levels
     */
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    /*
     * Loads the first level
     */ 
    public void LoadLevel()
    {
        SceneManager.LoadScene(2);
    }

    /*
     * Loads the Scene Selection Screen using the sceneIndex plus 1
     */ 
    public void SceneSelect()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    /*
     * Loads the Credit Scene Screen
     */ 
    public void CreditScene()
    {
        SceneManager.LoadScene(22);
    }
}