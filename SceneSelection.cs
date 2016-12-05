using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour {

    private int sceneIndex;

    /*
     * Start Function, is called upon Class initialization.
     * Makes a sceneIndex variable that holds the number of the current scene index to later be used to load levels
     */
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    /*
     * Loads level 1 using the current sceneIndex number plus 1
     */ 
    public void LevelOne()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    /*
     * Loads level 2 using the current sceneIndex number plus 2
     */
    public void LevelTwo()
    {
        SceneManager.LoadScene(sceneIndex + 2);
    }

    /*
     * Loads level 3 using the current sceneIndex number plus 3
     */
    public void LevelThree()
    {
        SceneManager.LoadScene(sceneIndex + 3);
    }

    /*
     * Loads level 4 using the current sceneIndex number plus 4
     */
    public void LevelFour()
    {
        SceneManager.LoadScene(sceneIndex + 4);
    }

    /*
     * Loads level 5 using the current sceneIndex number plus 5
     */
    public void LevelFive()
    {
        SceneManager.LoadScene(sceneIndex + 5);
    }

    /*
     * Loads level 6 using the current sceneIndex number plus 6
     */
    public void LevelSix()
    {
        SceneManager.LoadScene(sceneIndex + 6);
    }

    /*
     * Loads level 7 using the current sceneIndex number plus 7
     */
    public void LevelSeven()
    {
        SceneManager.LoadScene(sceneIndex + 7);
    }

    /*
     * Loads level 8 using the current sceneIndex number plus 8
     */
    public void LevelEight()
    {
        SceneManager.LoadScene(sceneIndex + 8);
    }

    /*
     * Loads level 9 using the current sceneIndex number plus 9
     */
    public void LevelNine()
    {
        SceneManager.LoadScene(sceneIndex + 9);
    }

    /*
     * Loads level 10 using the current sceneIndex number plus 10
     */
    public void LevelTen()
    {
        SceneManager.LoadScene(sceneIndex + 10);
    }

    /*
     * Loads level 11 using the current sceneIndex number plus 11
     */
    public void LevelEleven()
    {
        SceneManager.LoadScene(sceneIndex + 11);
    }

    /*
     * Loads level 12 using the current sceneIndex number plus 12
     */
    public void LevelTwelve()
    {
        SceneManager.LoadScene(sceneIndex + 12);
    }

    /*
     * Loads level 13 using the current sceneIndex number plus 13
     */
    public void LevelThirteen()
    {
        SceneManager.LoadScene(sceneIndex + 13);
    }

    /*
     * Loads level 14 using the current sceneIndex number plus 14
     */
    public void LevelFourteen()
    {
        SceneManager.LoadScene(sceneIndex + 14);
    }

    /*
     * Loads level 10 using the current sceneIndex number plus 10
     */
    public void LevelFifteen()
    {
        SceneManager.LoadScene(sceneIndex + 15);
    }

    /*
     * Loads level 16 using the current sceneIndex number plus 16
     */
    public void LevelSixteen()
    {
        SceneManager.LoadScene(sceneIndex + 16);
    }

    /*
     * Loads level 17 using the current sceneIndex number plus 17
     */
    public void LevelSeventeen()
    {
        SceneManager.LoadScene(sceneIndex + 17);
    }

    /*
     * Loads level 18 using the current sceneIndex number plus 18
     */
    public void LevelEighteen()
    {
        SceneManager.LoadScene(sceneIndex + 18);
    }

    /*
     * Loads level 19 using the current sceneIndex number plus 19
     */
    public void LevelNineteen()
    {
        SceneManager.LoadScene(sceneIndex + 19);
    }

    /*
     * Loads level 20 using the current sceneIndex number plus 20
     */
    public void LevelTwenty()
    {
        SceneManager.LoadScene(sceneIndex + 20);
    }
}
