using UnityEngine;
using UnityEngine.SceneManagement; //Used when changing to a different scene or reloading the scene

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }


    public void EndGame () {

        if (gameHasEnded == false)
        { 
        gameHasEnded = true;
        Debug.Log("GAME OVER");
            //Restart Game
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
